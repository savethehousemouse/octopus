#pragma once


class octopus
{

public:
	octopus(int, unsigned int, unsigned int, unsigned int, char);
	void Mix();
	void codeBlock(unsigned char *,unsigned int);
	void setSetBit(void(*)(int, bool));
	void setGetBit(bool(*)(int));
	unsigned int getMixBuffLength();
	bool getMode();
	~octopus();
};

