// See https://aka.ms/new-console-template for more information

//Establishes the array for angles
int[] angles = Enumerable.Range(0, 91).ToArray();
//Establishes the array for cos based off real data
decimal[] deci = {2, 1, 0.9998m, .9994m, .9986m, .9976m, .9962m, .9945m, .9926m, .9903m, .9877m, .9848m, .9816m, .9781m, .9744m, .9703m, .9659m, .9613m, .9563m, .9511m, .9455m, .9397m, .9336m, .9272m, .9205m, .9135m, .9063m, .8988m, .8910m, .8829m, .8746m, .8660m, .8571m, .8480m, .8387m, .8290m, .8191m, .8090m, .7986m, .7880m, .7772m, .7660m, .7547m, .7431m, .7314m, .7193m, .7071m, .6947m, .6820m, .6691m, .6561m, .6428m, .6293m, .6157m, .6018m, .5878m, .5736m, .5592m, .5446m, .5299m, .5150m, .5000m, .4848m, .4695m, .4540m, .4384m, .4226m, .4067m, .3907m, .3746m, .3584m, .3420m, .3256m, .3090m, .2924m, .2756m, .2588m, .2419m, .2249m, .2079m, .1908m, .1736m, .1564m, .1392m, .1219m, .1045m, .0872m, .0698m, .0523m, .0349m, .0174m, 0, -0.01m};
int end = 1;
int i;
//while loop to allow for repetition
while (end != 0)
{
    //resets i so the code can bbe run over and over again
    i = 0;
    //explains what the user should do and allows input
    Console.Write("Enter Cosine:");
    decimal dec = decimal.Parse(Console.ReadLine());
    //loops through all of the decimals in deci
    for (i = 0; i < deci.Length; i++)
    {
        //if the input is outside the bounds of what cos can be then it tells you to try again and allows to restart the code
        if (dec > 1 || dec < 0)
        {
            Console.WriteLine("Please Remember To Choose A number between 1-0");
            i = angles.Length;
            //gives option for player to restart or quit
            Console.Write("Enter y to go again or other to close:");
            string entered = Console.ReadLine();
            if (entered == "y")
            {
                end = 1;
                continue;
            }
            else
            {
                end = 0;
                return;
            }
        }
        //finds the difference between the current array spot with the input and the array spot ahead of the current with the input
        decimal current1 = Math.Abs(deci[i] - dec);
        decimal current2 = Math.Abs(deci[i + 1] - dec);
        //checks to see if the current array or the one ahead is closer to the input, if the one ahead is closer then it goes again
        if (current1 > current2)
        {
            continue;
        }
        //once it gets to a spot where the current array spot is closer to the input the calculates the angle
        else if (current1 <= current2)
        {
            //uses algorithm I made to find the ratio of how close the input is to the closer number compared to the farther of the two,
            //for example is input is 4 and the closest are 5 and 2 then it does 5-2 = 3 and 5-4 is 1 so 1/3 is how close the input is to the farther one
            decimal ratio = deci[i] - deci[i + 1];
            decimal Addon = Math.Abs(current1 / ratio);
            //gets ready to tell the angle
            Console.Write("Your Approximate Angle Is:");
            //adds the angle that correlates with the decimal you are on + the ratio of how close you are
            Console.WriteLine(" " + Math.Round(angles[i - 1] + Addon, 4).ToString());
            //sets i to deci.length so that the for loop doesnt go again
            i = deci.Length;
            //gives option to restart or quit the application
            Console.Write("Enter y to go again or other to close:");
            string entered = Console.ReadLine();
            if (entered == "y")
            {
                end = 1;
            }
            else
            {
                end = 0;
            }
        }
    }
}
