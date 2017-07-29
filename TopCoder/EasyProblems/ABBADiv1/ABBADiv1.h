#pragma once
#include <string>
using namespace std;
class ABBADiv1
{
	public:
		
		string canObtain(string initial, string target)
		{
			return (solution(initial, target)) ? "Possible" : "Impossible";
		}
	
	private:

		bool possible;
		
		bool solution(string initial, string target)
		{
			if (initial.length() >= target.length())
			{
				return possible || initial == target;
			}

			if (target.front() == 'B')
				possible = possible || solution(initial, reverseString(target).substr(0, target.length() - 1));
			if (target.back() == 'A')
				possible = possible || solution(initial, target.substr(0, target.length() - 1));

			return possible;
		}

		string reverseString(string s)
		{
			string temp;

			for (int i = s.length() - 1; i >= 0; i--)
			{
				temp += s[i];
			}

			return temp;
		}
};

