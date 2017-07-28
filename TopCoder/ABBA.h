/*
* Guillermo Alicea
* 07.27.17
* Problem: ABBA
*
*/

#pragma once
#include <string>
#include <map>

using namespace std;
class ABBA
{
	public:

		string canObtain(string initial, string target)
		{
			for (int i = target.length() - 1; i >= initial.length(); i--)
			{
				if (target.back() == 'B')
				{
					target = reverseString(target.substr(0, i));
					continue;
				}

				target = target.substr(0, i);
			}

			return (initial == target) ? "Possible" : "Impossible";
		}

	private:

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

