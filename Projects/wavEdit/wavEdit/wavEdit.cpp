// wavEdit.cpp : Defines the entry point for the console application.
//
#define _CRT_SECURE_NO_WARNINGS
#include    <stdio.h>
//#include	<unistd.h>

#include	<sndfile.h>
#include "octopus.h"
#include "mtrand.h"

/* Include this header file defining functions in libsndfile. */
#include    <sndfile.hh>

/* This will be the length of the buffer used to hold samples while
** we process them.
*/
#define BUFFER_LEN      1024
void setBit(int, bool);
bool getBit(int);

/* libsndfile can handle more than 6 channels but we'll restrict it to 6. */
#define    MAX_CHANNELS    6
#pragma comment (lib, "libsndfile-1.lib")
/* Function prototype. */
static void process_data(short *data, int count, int channels);
static octopus *myOctopus = 0;
unsigned int codeBuffSize = 10;
unsigned int xresidualPerc = 10;
unsigned int xdisplacement = 0;
unsigned int dataBuffLen = 0;
char direction = 'e';
char *inFileName = (char*)calloc(512,1);
char *outFileName = (char*)calloc(512,1);
char *codeFileName = (char*)calloc(512,1);
char *buff = (char *)calloc(512, 1);
/* This is a buffer of double precision floating point values
** which will hold our data while we process it.
*/
short int *data;
FILE *codeFile=0;
unsigned char *codeBuffer;

int main(int argc, char **argv)
{
	/* A SNDFILE is very much like a FILE in the Standard C library. The
	** sf_open_read and sf_open_write functions return an SNDFILE* pointer
	** when they sucessfully open the specified file.
	*/
	SNDFILE      *infile=0, *outfile=0;

	/* A pointer to an SF_INFO stutct is passed to sf_open_read and sf_open_write
	** which fill this struct with information about the file.
	*/
	char *fd1, *fd2, *strt;
	bool encode = true;
	SF_INFO      sfinfo;
	int seed = 0;
	long long    readcount
		,		 readcount2;
	/*
	srand(123);
	codeBuffSize = 10;
	xresidualPerc = 10;
	xdisplacement = 0;
	dataBuffLen = 0;
	direction='d';
	inFileName	= "b:\\snds\\input.wav";
	outFileName	= "b:\\snds\\output.wav";
*/
	*buff = '|';
	strcat(buff + 1, argv[1]);
	strcat(buff,",=");
	strt = buff;
/*
              123456789012345
 */
	 char *parms="|mode         |codefile     |srcfilein    |srcfileout   |seed         |residualperc |blocklen     |displacement |";
	 size_t token = 0;
	 char *fd3;
	 while (*strt != 0)
	 {
		 *strt = tolower(*strt);
		 strt++;
	 }

	 strt = buff;
	while ((fd1 = strchr(strt, '=')) != 0)
	{
		if (strlen(fd1) < 2) break;
		*fd1 = 0, fd1++;
		fd2 = strchr(fd1, ',');
		*fd2 = 0, fd2++;
		if ((fd3=strstr(parms, strt)) != 0)
		{
			token = (fd3-parms)/14;
			switch (token)
			{
				case 0:	// mode
					if (*(fd1) == 'e') direction = 'e';
					else direction = 'd';
					break;
				case 1:	// codefile
					strcpy(codeFileName,fd1);
					break;
				case 2:	// srcfilein
					inFileName = (fd1);
					break;
				case 3:	// srcfileout
					outFileName = (fd1);
					break;
				case 4:	// seed
				{
							seed = atoi(fd1);
							srand(seed);
							break;
				}
				case 5: // residualperc
					xresidualPerc = atoi(fd1);
					break;
				case 6: //blocklen
					codeBuffSize = atoi(fd1);
					break;
				case 7: // displacement
					xdisplacement = atoi(fd1);
					break;
				default:
					break;
			}
			strt=fd2;
		}
	}

	myOctopus = new octopus(seed, codeBuffSize, xresidualPerc, xdisplacement, direction);
	encode = myOctopus->getMode();
	if (!encode) strcat(codeFileName, ".out");

	myOctopus->setGetBit(getBit);
	myOctopus->setSetBit(setBit);
	dataBuffLen = myOctopus->getMixBuffLength();
	codeBuffer = (unsigned char *)calloc(codeBuffSize+2, 1);

	data = (short *)calloc(dataBuffLen, sizeof(short));
	/* Here's where we open the input file. We pass sf_open_read the file name and
	** a pointer to an SF_INFO struct.
	** On successful open, sf_open_read returns a SNDFILE* pointer which is used
	** for all subsequent operations on that file.
	** If an error occurs during sf_open_read, the function returns a NULL pointer.
	*/
	char *srcFileName, *tgtFileName;
	char *codeMode;

	if (encode)
	{
		codeMode = "r";
		srcFileName = inFileName;
		tgtFileName = outFileName;

	}
	else
	{
		codeMode = "w";
		srcFileName = outFileName;
		tgtFileName = codeFileName;
	}

	if (!(codeFile = fopen(codeFileName, codeMode)))
	{   /* Open failed so print an error message. */
		printf("Not able to open code file %s.\n", codeFileName);
		/* Print the error message fron libsndfile. */
		return  1;
	};

//	sfinfo.format = ((sfinfo.format & 0xffffff00) | 1);
	/* Open the output file. */

	if (!(infile = sf_open(srcFileName, SFM_READ, &sfinfo)))
	{
		printf("Not able to open source file %s.\n", outFileName);
		sf_perror(NULL);
		return  1;
	};
	if (sfinfo.channels > MAX_CHANNELS)
	{
		printf("Not able to process more than %d channels\n", MAX_CHANNELS);
		return  1;
	};
	if (encode)
	{
		if (!(outfile = sf_open(tgtFileName, SFM_WRITE, &sfinfo)))
		{
			printf("Not able to open target file %s.\n", outFileName);
			sf_perror(NULL);
			return  1;
		}
	}


	/* While there are samples in the input file, read them, process
	** them and write them to the output file.
	*/
	bool eofcode = false;
	bool eofmix = false;
		while ((readcount = sf_read_short(infile, data, dataBuffLen)))
		{
//			printf("\tread sound: %d", readcount);
				if (!eofmix)
				{
					if (encode)
					{
						if (!eofcode)
						{
							readcount2 = fread(codeBuffer, 1, codeBuffSize, codeFile);
							if ((eofcode = (readcount2 < codeBuffSize)))
							{
								printf("\teof CodeData: %d", readcount2);
								readcount2 = codeBuffSize;
							}
							process_data(data,((int)readcount), sfinfo.channels);
							memset(codeBuffer, 0, codeBuffSize);
						}
					}
					else
					{
						process_data(data, ((int)readcount), sfinfo.channels);
					}
					eofmix = (readcount < dataBuffLen);
				}
				if (encode)
				{
					sf_write_short(outfile, data, readcount);
					printf("\twrote mix: %d", readcount);
				}
				else
				{
					unsigned int l = 0;
					fprintf(codeFile,"%s", codeBuffer);
					printf("\twrote code: %d\n", (l=strlen((char *)codeBuffer)));
					if (l < codeBuffSize)
						break;
				}
			memset(data,0, (size_t)dataBuffLen);
			if (eofmix) break;
		}
	printf("done");
	free(buff);

	/* Close input and output files. */
	if (infile != 0)		sf_close(infile);
	if (outfile != 0)	sf_close(outfile);
	if (codeFile != 0)	fclose(codeFile);

	return 0;
} /* main */

void setBit(int pos, bool val)
{
	if (val)
		data[pos] |= 1;
	else
	data[pos] &= 0xfffe;
}
bool getBit(int pos)
{
	return((data[pos] & 0x00001) != 0);
}

static void process_data(short *data, int count, int channels)
{
	double channel_gain[MAX_CHANNELS] = { 0.5, 0.8, 0.1, 0.4, 0.4, 0.9 };
//	int k, chan;
	myOctopus->Mix();

	/* Process the data here.
	** If the soundfile contains more then 1 channel we need to take care of
	** the data interleaving youself.
	** Current we just apply a channel dependant gain.
	*/
	myOctopus->codeBlock(codeBuffer,((unsigned int)count<codeBuffSize) ? count : codeBuffSize);

	return;
} /* process_data */