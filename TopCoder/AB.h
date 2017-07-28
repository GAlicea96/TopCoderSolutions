#pragma once
#include <string>

using namespace std;
class AB
{
	public:

		string oneAnswer;
		int N;
		int K;

		string createString(int N, int K)
		{
			this->N = N;
			this->K = K;

			answerFinder("");

			return oneAnswer;
		}

	private:

		void answerFinder(string current)
		{
			if (current.length() == N)
			{
				if (isValid(current))
				{
					oneAnswer = current;
				}
				return;
			}

			answerFinder(current + "A");
			answerFinder(current + "B");
		}

		bool isValid(string candidate) const
		{
			int kCount = 0;
			int length = candidate.length();

			for (int j = 0; j < length; j++)
			{
				if (candidate[j] != 'A') continue;

				for (int g = j + 1; g < length; g++)
				{
					if (candidate[g] == 'B')
					{
						kCount++;
					}
				}
			}

			//Valid string found
			return kCount == K;
		}
};


