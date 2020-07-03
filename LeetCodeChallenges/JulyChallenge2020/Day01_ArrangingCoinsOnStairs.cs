using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeChallenges.JulyChallenge2020
{
    class Day01_ArrangingCoinsOnStairs
    {
        var stairs = 0;
            while(n >= (stairs+1)){
            
            n = n - (stairs + 1);
            
            if(n< 0){
                break;
            }

            stairs++;
        }
               
        return stairs;
    }
}
