//Program written by Dan Plummer and Derek West
//1/.20.17
//CIS 2620 | Chapter 2 | Case Study #1

//2/15/17
//CIS 2620 | Chapter 4 | Case Study #1

//2/26/17
//CIS 2620 | Chapter 5 | Case Study #1

//3/15/2017 
//CIS 2620 | Chapter 6 | Case Study #1

//3/22/2017
//CIS 2620 | Chapter 7 | Case Study #1

using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        int lastYearNum, thisYearNum;
        string lastYear, thisYear;
        double admission = 25.00, revenue;

        Write("For last year, ");
        lastYearNum = Contestants();
        Write("For this year, ");
        thisYearNum = Contestants();


        while (lastYearNum < 0 || lastYearNum > 30)
        {
            Write("Invalid entry, please enter a number from 0 to 30: ");
            Contestants();
        }

        bool moreThisYear = thisYearNum > lastYearNum;
        revenue = thisYearNum * admission;

        while (thisYearNum < 0 || thisYearNum > 30)
        {
            Write("Invalid entry, please enter a number from 0 to 30: ");
            thisYear = ReadLine();
            thisYearNum = Int32.Parse(thisYear);
        }

        string[] contestantTalents = { "S", "D", "M", "O" };
        string[] currentNames = { };
        string[] currentTalents;
        string[] names = new string[thisYearNum];
        string[] talents = new string[thisYearNum];
        int[] talentCounts = { 0, 0, 0, 0 };
        currentNames = new string[thisYearNum];
        string inputSkill, inputName;
        bool isValid = false;
        int x = 0;
        int y = 0;

        while (x < thisYearNum)

        {
            Write("Please enter the name for Contestant #{0}: ", x + 1);
            inputName = ReadLine();
            names[x] = inputName;
            Write("Please enter a skill, either S for singing, D for Dancing, M for Musical Intrument, or O for Other: ");
            inputSkill = ReadLine();

            while (isValid == false)
            {
                for (y = 0; y < contestantTalents.Length; y++)
                {
                    if (inputSkill == contestantTalents[y])
                    {
                        isValid = true;
                        talentCounts[y] += 1;
                        talents[x] = inputSkill;
                    }
                }
                if (isValid == false)
                {
                    WriteLine("The skill you have entered is invalid.");
                    Write("Please enter a skill, either S for singing, D for Dancing, M for Musical Intrument, or O for Other: ");
                    inputSkill = ReadLine();
                }

            }

            currentNames[x] = Convert.ToString(inputName);
            x += 1;
            isValid = false;


        }

        makeArray(names, talents);

        //inputSkill = "";
        //while (inputSkill != "Q")
        //{
        //    WriteLine("Enter a talent code to see how many contestants will be showcasing that talent this year OR enter Q to quit: ");
        //    inputSkill = ReadLine();
        //    for (y = 0; y < contestantTalents.Length; y++)
        //    {
        //        if (inputSkill == contestantTalents[y])
        //        {
        //            WriteLine("{0} contestant(s) will be showcasing that talent this year.", talentCounts[y]);
        //        }
        //    }
        //}

        //Chapter 7 addition
        RaceMessage(thisYearNum, lastYearNum);
        WriteLine();
        WriteLine("Expected revenue for this year's competition is: ${0}", revenue.ToString("F2"));
    }

    //Chapter 7 addition begin

    private static int Contestants()
    {
        string userInput;
        int numContestants;

        WriteLine("please enter the number of contestants: ");
        userInput = ReadLine();
        numContestants = Convert.ToInt32(userInput);
        return numContestants;
    }
    private static void RaceMessage(int valThisYear, int valLastYear)
    {

        if (valThisYear > (valLastYear * 2))
            WriteLine("The Competition is more than twice as big this year!");
        else
               if (valThisYear > valLastYear)
            WriteLine("The competition is bigger than ever!");
        else
               if (valThisYear < valLastYear)
            WriteLine("A tighter race this year! Come out and cast your vote.");
    }

    private static void makeArray(string[] competitor, string[] talent)
    {
        WriteLine("{0, 10} {1, 10}", "Name", "Talent");
        for (int x = 0; x < competitor.Length; ++x)
        {
            for (int y = 0; y < talent.Length; ++y)
            {
                WriteLine("{0, 10} {1, 10}", competitor[x], talent[y]);
            }
        }
    }
    //Chapter 7 additon end
}