using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksSolver
{
    public class Turn
    {

        public static void Right(string[,,] cube)
        {
            string temp1, temp2, temp3;
            // update back
            temp1 = cube[4, 0, 0];
            temp2 = cube[4, 1, 0];
            temp3 = cube[4, 2, 0];
            cube[4, 2, 0] = cube[0, 0, 2];
            cube[4, 1, 0] = cube[0, 1, 2];
            cube[4, 0, 0] = cube[0, 2, 2];

            // update up
            cube[0, 0, 2] = cube[2, 0, 2];
            cube[0, 1, 2] = cube[2, 1, 2];
            cube[0, 2, 2] = cube[2, 2, 2];

            // update front
            cube[2, 0, 2] = cube[5, 0, 2];
            cube[2, 1, 2] = cube[5, 1, 2];
            cube[2, 2, 2] = cube[5, 2, 2];

            // update down
            cube[5, 0, 2] = temp3;
            cube[5, 1, 2] = temp2;
            cube[5, 2, 2] = temp1;

            // update right
            temp1 = cube[3, 0, 0];
            temp2 = cube[3, 0, 1];
            cube[3, 0, 0] = cube[3, 2, 0];
            cube[3, 0, 1] = cube[3, 1, 0];
            cube[3, 2, 0] = cube[3, 2, 2];
            cube[3, 1, 0] = cube[3, 2, 1];
            cube[3, 2, 2] = cube[3, 0, 2];
            cube[3, 2, 1] = cube[3, 1, 2];
            cube[3, 1, 2] = temp2;
            cube[3, 0, 2] = temp1;


        }
        public static void Left(string[,,] cube)
        {
            // update left
            string temp1 = cube[1, 0, 0];
            string temp2 = cube[1, 0, 1];

            cube[1, 0, 0] = cube[1, 2, 0];
            cube[1, 0, 1] = cube[1, 1, 0];

            cube[1, 2, 0] = cube[1, 2, 2];
            cube[1, 1, 0] = cube[1, 2, 1];

            cube[1, 2, 2] = cube[1, 0, 2];
            cube[1, 2, 1] = cube[1, 1, 2];

            cube[1, 0, 2] = temp1;
            cube[1, 1, 2] = temp2;
            // update back
            temp1 = cube[4, 0, 2];
            temp2 = cube[4, 1, 2];
            string temp3 = cube[4, 2, 2];

            cube[4, 2, 2] = cube[5, 0, 0];
            cube[4, 1, 2] = cube[5, 1, 0];
            cube[4, 0, 2] = cube[5, 2, 0];
            // update down
            cube[5, 0, 0] = cube[2, 0, 0];
            cube[5, 1, 0] = cube[2, 1, 0];
            cube[5, 2, 0] = cube[2, 2, 0];
            // update front
            cube[2, 0, 0] = cube[0, 0, 0];
            cube[2, 1, 0] = cube[0, 1, 0];
            cube[2, 2, 0] = cube[0, 2, 0];
            // update top
            cube[0, 0, 0] = temp3;
            cube[0, 1, 0] = temp2;
            cube[0, 2, 0] = temp1;

        }

    }
}
