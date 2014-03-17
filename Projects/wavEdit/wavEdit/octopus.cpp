#include <string.h>      /* printf, NULL */
#include <stdio.h>      /* printf, NULL */
#include <stdlib.h>     /* srand, rand */
#include <time.h>       /* time */
#include <sys/stat.h>
#include <ctype.h>
#include "mtrand.h"

#include "octopus.h"

char				mode;

long long			ky = time(0);
unsigned int		cdBuffLen = 0
,					residualPerc = 0
;
unsigned char		*codeBuff = 0
;

unsigned int		useLen = 0
,					displacement = 0
,					mixBuffLen = 0

,					*srcOrd = 0
,					*ord = 0
;
;

bool				encode = true
;

void (*setBit)(int, bool);
bool (*getBit)(int);
//
void setSetBit(void (*)(int, bool));
void setGetBit(bool(*)(int));
MTRand_int32 irand;

//bool (*setGetBit)(int);
//void (*setSetBit)(void(*)(int, bool));
//
unsigned int octopus::getMixBuffLength() { return (mixBuffLen); }

void octopus::setSetBit(void (xsetBit)(int, bool)){ setBit = xsetBit; }
void octopus::setGetBit(bool (xgetBit)(int)){ getBit = xgetBit; }

bool octopus::getMode() { return(encode); }
octopus::octopus(int seed, unsigned newCodeBuffSize, unsigned int newResidualPerc, unsigned int newDisplacement,char newDirection)
{
	encode = (strchr("eE", newDirection) != 0);
	//	calculate and allocate outBuffer
	useLen = newCodeBuffSize;
	mixBuffLen = ((useLen*8*(100 + newResidualPerc)) / 100);

	//	calculate and allocate mixSource
	srcOrd = (unsigned int *)calloc(mixBuffLen, sizeof(int));
	//	calculate and allocate mixUsed
	ord = (unsigned int *)calloc(mixBuffLen, sizeof(int));
	displacement = newDisplacement;
	irand.seed(seed);
}

void octopus::Mix(void)
{
		unsigned int i = 0, j = 0, x = 0;

		for (i = 0; i<mixBuffLen; i++) srcOrd[i] = i;
		//for (i = 0; i<mixBuffLen; i++) ord[i] = i;
		//return;
		j = 0;
		int tmp,tmp2;
	for (i = mixBuffLen - 1; i>0; i--)
	{
		ord[j++] = srcOrd[(x = (((tmp2 = ((tmp = irand()) % i)) + displacement) % mixBuffLen))];
		srcOrd[x] = srcOrd[i];
	}
	ord[j] = srcOrd[0];
}
octopus::~octopus()
{
	if (srcOrd != 0)
		free(srcOrd);
	srcOrd = 0;
	if (ord != 0)
		free(ord);
	ord = 0;
}


void octopus::codeBlock(unsigned char *codeBuff,unsigned int inlen)
{
	static unsigned int i, j;
	bool what = false;
	static unsigned char dc[] = { 1, 2, 4, 8, 16, 32, 64, 128 };
	if (encode);
	else
		memset((void *)codeBuff, 0, inlen);

	for (i = 0; i<inlen; i++)
	{
		for (j = 0; j<8; j++)
			if (encode)		setBit(ord[i * 8 + j], (what = ((codeBuff[i] & dc[j]) != 0)));
			else			codeBuff[i] += (getBit(ord[i * 8 + j]) ? dc[j] : 0);
		if (codeBuff[i] == 0)
			return;
	}
}

