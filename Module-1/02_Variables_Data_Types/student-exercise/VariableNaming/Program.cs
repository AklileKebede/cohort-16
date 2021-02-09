using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;

<<<<<<< HEAD
            Console.WriteLine("Q.1 & Q.2 were examplese");

            Console.WriteLine(" Q.3: 3 raccoons are playing in the woods. 2 go home to eat dinner.\nHow"
            + " many raccoons are left in the woods?");
            int coonsInWoods = 3;
            int coonsWentHome = 2;
            int coonsRemaining = coonsInWoods - coonsWentHome;
            Console.WriteLine(coonsRemaining + " raccoon left in the woods");

            Console.WriteLine("\nQ.4: There are 5 flowers and 3 bees.\nHow many less bees than flowers?");
            int flowers = 5;
            int bees = 3;
            int differenceBeesFlowers = flowers - bees;
            Console.WriteLine("There were " + differenceBeesFlowers + " bees less than flowers");

            Console.WriteLine("\nQ.5: 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat"
            + " breadcrumbs, too.\nHow many pigeons are eating breadcrumbs now?");
            int lonelyPigeon = 1;
            int anotherPigeon = 1;
            int totalPigeons = lonelyPigeon + anotherPigeon;
            Console.WriteLine("There are " + totalPigeons + " pigeons are eating breadcrumbs");

            Console.WriteLine("\nQ.6: 3 owls were sitting on the fence. 2 more owls joined them.\nHow many"
            + " owls are on the fence now?");
            int owlsOnFence = 3;
            int owlsJoined = 2;
            int totalOwlsOnFence = owlsOnFence + owlsJoined;
            Console.WriteLine("There are " + totalOwlsOnFence + " owls on the fence");

            Console.WriteLine("\nQ.7: 2 beavers were working on their home. 1 went for a swim.\nHow many"
            + " beavers are still working on their home?");
            int workingBeavers = 2;
            int swimmingBeavers = 1;
            int diffWorkingBeavers = workingBeavers - swimmingBeavers;
            Console.WriteLine(diffWorkingBeavers + " beaver still working on the home");

            Console.WriteLine("\nQ.8: Two toucans are sitting on a tree limb. 1 more toucan joins them.\nHow"
            + " many toucans in all?");
            int sittingToucans = 2;
            int joiningToucan = 1;
            int totalToucanOnTree = sittingToucans + joiningToucan;
            Console.WriteLine("There are " + totalToucanOnTree + " toucans sitting on a tree");

            Console.WriteLine("\nQ.9: There are 4 squirrels in a tree with 2 nuts. \nHow many more squirrels"
            + " are there than nuts ?");
            int squirrels = 4;
            int nuts = 2;
            int diffSquirrelsNuts = squirrels - nuts;
            Console.WriteLine("There are " + diffSquirrelsNuts + " more squirrels then nuts");

            Console.WriteLine("\nQ.10: Mrs.Hilt found a quarter, 1 dime, and 2 nickels.\nHow much money did"
            + " she find?");
            decimal quarter = .25M;
            decimal dime = .10M;
            decimal nickels = .05M;
            decimal foundMoney = quarter + dime + (2 * nickels);
            Console.WriteLine("Mrs. Hilt found $" + foundMoney);

            Console.WriteLine("\n11. Mrs.Hilt's favorite first grade classes are baking muffins. Mrs. Brier's"
            + " class bakes 18 muffins, Mrs.MacAdams's class bakes 20 muffins, and"
            + " Mrs.Flannery's class bakes 17 muffins.\nHow many muffins does first"
            + " grade bake in all?");

            int brierClassMuffins = 18;
            int macadamsClassMuffins = 20;
            int flanneryClassMuffins = 17;
            int firstGradeBakedMuffins = brierClassMuffins + macadamsClassMuffins + flanneryClassMuffins;
            Console.WriteLine("First graders baked " + firstGradeBakedMuffins + " muffins");

            Console.WriteLine("\nQ.12: Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents.\n How"
            + " much did she spend in all for the two toys?");
            decimal yoyoCost = .24M;
            decimal whistleCost = .14M;
            decimal hiltSpentMoney = yoyoCost + whistleCost;
            Console.WriteLine("Mrs. Hilt spent $" + hiltSpentMoney + " at the store");

            //13
            Console.WriteLine("\nQ.13: Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows"
            + " and 10 mini marshmallows.\nHow many marshmallows did she use"
            + " altogether?");
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;
            Console.WriteLine("Mrs. Hilt used a total of " + totalMarshmallows + " marshmallows");

            //14
            Console.WriteLine("\nQ.14: At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock"
            + "Elementary School received 17 inches of snow.\nHow much more snow"
            + "did Mrs.Hilt's house have?");
            double hiltHouseSnow = 29;
            double brecknockElementarySchool = 17;
            double diffSnow = hiltHouseSnow - brecknockElementarySchool;
            Console.WriteLine("Mrs. Hilt's house got additional" + diffSnow + " inches of snow" );
            
            //15
            Console.WriteLine("\nQ.15: Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil"
            + " case.\nHow much money does she have left?");
            decimal hiltMoney = 10.00M;
            decimal toyTruck = 3.00M;
            decimal pencil = 2.00M;
            hiltMoney -= (toyTruck + pencil);
            Console.WriteLine("Mrs. Hilt has $" + hiltMoney + " left");
            
            //16
            Console.WriteLine("\nQ.16: Josh had 16 marbles in his collection. He lost 7 marbles.\nHow many"
            + " marbles does he have now?\n");
            int joshMarbleCollection = 16;
            int joshLostMarbles = 7;
            int joshleftMarbles = joshMarbleCollection - joshLostMarbles;
            Console.WriteLine("Josh has " + joshleftMarbles + " marbles left");
            
            //17
            Console.WriteLine("\nQ.17: Megan has 19 seashells.\nHow many more seashells does she need to"
            + " find to have 25 seashells in her collection?\n");
            int meganSeashells = 19;
            int meganDesiredSeashells = 25;
            int seashellsNeeded = meganDesiredSeashells - meganSeashells;
            Console.WriteLine("Megan needs " + seashellsNeeded + " more seashells in her collection");

            //18
            Console.WriteLine("\nQ.18: Brad has 17 balloons. 8 balloons are red and the rest are green.\nHow"
            + " many green balloons does Brad have?\n");
            int bradTotalBalloons = 17;
            int bradRedBalloons = 8;
            int greenBalloons = bradTotalBalloons - bradRedBalloons;
            Console.WriteLine("Brad has " + greenBalloons + " green balloons");
            
            //19
            Console.WriteLine("\nQ.19: There are 38 books on the shelf.Marta put 10 more books on the shelf.\n"
            + "How many books are on the shelf now?\n");

            int currentBooksOnShelf = 38;
            int martaAddBooks = 10;
            int totalBooksOnShelf = currentBooksOnShelf + martaAddBooks;
            Console.WriteLine("There are " + totalBooksOnShelf + " books on the shlef");

            //20
            Console.WriteLine("\nQ.20: A bee has 6 legs.How many legs do 8 bees have?\n" );
            int legsBeeHas = 6;
            int numberOfBees = 8;
            int totalNumberOfBeeLegs = legsBeeHas * numberOfBees;
            Console.WriteLine("8 bees have altogether " + totalNumberOfBeeLegs + " legs");

            //21
            Console.WriteLine("\nQ.21: Mrs. Hilt bought an ice cream cone for 99 cents.\nHow much would 2 ice"
            + "cream cones cost?");
            decimal oneIcecreamConeCost = .99M;
            int icecreamConesBought = 2;
            decimal boughtIcecreamCones = oneIcecreamConeCost * icecreamConesBought;
            Console.WriteLine("Mrs. Hilt paid $" + boughtIcecreamCones);
=======
            Console.WriteLine(5/3);
            Console.WriteLine((double)5/3);
            Console.WriteLine((decimal)5 / 3);
            Console.WriteLine((double)3 / 5);
            Console.WriteLine((decimal)3 / 5);

            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            Console.WriteLine("\nQ.22:");
            int rocksNeededForBorder = 125;
            int rocksHiltHas = 64;
            int rocksToCompleteBorder = rocksNeededForBorder - rocksHiltHas;
            Console.WriteLine("Mrs. Hilt needs " + rocksToCompleteBorder + " more rocks to complete the border");
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            Console.WriteLine("\nQ.23:");
            int marbles = 38;
            int lostMarbles = 15;
            int marblesLeft = marbles - lostMarbles;
            Console.WriteLine("Mrs. Hilt has " + marblesLeft + " marbles Left");

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            Console.WriteLine("\nQ.24:");
            double concertDistance = 78.00;
            double firstStop = 32.00;
            double distanceLeft = concertDistance - firstStop;
            Console.WriteLine("Distance left to drive is " + distanceLeft + " miles");
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            Console.WriteLine("\nQ.25:");
            double morningShovel = 90.00;
            double afternoonShovel = 45.00;
            double totalShovelTime = (morningShovel + afternoonShovel);
            Console.WriteLine("It took " + totalShovelTime + " minutes to shovel");
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            Console.WriteLine("\nQ.26:");
            int hotdogsBought = 6;
            decimal oneHotdogCost = .50M;
            decimal payedForHotdogs = hotdogsBought * oneHotdogCost;
            Console.WriteLine("Mrs. Hilt payed a total of $" + payedForHotdogs + " for the hotdogs");
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            Console.WriteLine("\nQ.27:");
            decimal has = .50M;
            decimal pencilCost = .07M;
            decimal pencilAfforded = Math.Truncate(has / pencilCost);
            Console.WriteLine(" Mrs. Hilt can buy " + pencilAfforded + " penciles");
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            Console.WriteLine("\nQ.28:");
            int hasButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = hasButterflies - orangeButterflies;
            Console.WriteLine("Mrs. Hilt has " + redButterflies + " red butterflies");

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            Console.WriteLine("\nQ.29:");
            decimal clerkGot = 1.00M;
            decimal candyCost = .54M;
            decimal change = clerkGot - candyCost;
            Console.WriteLine("Kate's change is $" + change);

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            Console.WriteLine("\nQ.30:");
            int treesNow = 13;
            int plantMoreTrees = 12;
            int sumTrees = treesNow + plantMoreTrees;
            Console.WriteLine("Mark will have " + sumTrees + " trees");
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            Console.WriteLine("\nQ.31:");
            int hoursInDay = 24;
            int daysRemaining = 2;
            int hoursLeft = hoursInDay * daysRemaining;
            Console.WriteLine("Joy has " + hoursLeft + " hours left to see her grandma");
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            Console.WriteLine("\nQ.32:");
            int cousins = 4;
            int gumPerCousin = 5;
            int gumNeeded = cousins * gumPerCousin;
            Console.WriteLine("Kim will need " + gumNeeded + " gum");
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            Console.WriteLine("\nQ.33:");
            decimal danHas = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal moneyLeftDan = danHas - candyBarCost;
            Console.WriteLine("Dan is left with $" + moneyLeftDan);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            Console.WriteLine("\nQ.34:");
            int boatsInLake = 5;
            int personPerBoat = 3;
            int peopleInLake = boatsInLake * personPerBoat;
            Console.WriteLine(peopleInLake + " people on boats");
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            Console.WriteLine("\nQ.35:");
            int legos = 380;
            int lostLegos = 57;
            int remainingLegos = legos - lostLegos;
            Console.WriteLine("Ellan has " + remainingLegos + " legos left");
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            Console.WriteLine("\nQ.36:");
            int bakedMuffins = 35;
            int wantedMuffins = 83;
            int muffinsToBake = wantedMuffins - bakedMuffins;
            Console.WriteLine(muffinsToBake + " muffins");

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            Console.WriteLine("\nQ.37:");
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int diffInCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine("Will has " + diffInCrayons + " more crayons then Lucy");

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            Console.WriteLine("\nQ.38:");
            int stickerPerPage = 10;
            int pagesOfStickers = 22;
            int sumOfStickers = stickerPerPage * pagesOfStickers;
            Console.WriteLine("Total number of stickers is " + sumOfStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            Console.WriteLine("\nQ.39:");
            int cupcakes = 96;
            int children = 8;
            int cupcakePerChild = cupcakes / children;
            Console.WriteLine("Each child will get " + cupcakePerChild + " cupcakes");
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            Console.WriteLine("\nQ.40:");
            double cookies = 47;
            double cookiePerJar = 6;
            double notPlacedCookies = cookies % cookiePerJar;
            Console.WriteLine(notPlacedCookies + " cookies couldn't be placed");

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            Console.WriteLine("\nQ.41:");
            double croissants = 59;
            int neighbors = 8;
            double croissantLeft = croissants % neighbors;
            Console.WriteLine( croissantLeft + " croissants left with Marian");
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            Console.WriteLine("\nQ.42:");
            int oatmealPerTray = 12;
            int totalOatmeal = 276;
            int traysNeeded = totalOatmeal / oatmealPerTray;
            Console.WriteLine(traysNeeded + " trays are needed");

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            Console.WriteLine("\nQ.43:");
            int pretzels = 480;
            int servingPretzel = 12;
            int servingsMade = pretzels / servingPretzel;
            Console.WriteLine(servingsMade + " servings of bite-sized pretzels");

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            Console.WriteLine("\nQ.44:");
            int lemon = 53;
            int remaininglemon = 2;
            int givenlemon = (lemon - remaininglemon);
            int lemonBoxs = givenlemon / 3;
            Console.WriteLine(lemonBoxs +" boxes were given away");

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            Console.WriteLine("\nQ.45:");
            int carrot = 74;
            int people = 12;
            int uneatenCarrot = carrot % people;
            Console.WriteLine(uneatenCarrot + "uneaten carrot sticks were left");
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int sistersteddies = 98;
            int shelfmax = 7;
            int shelffilled = sistersteddies / shelfmax;
            Console.WriteLine(shelffilled + " shelves filled with teddy bears");
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            Console.WriteLine("\nQ.47:");
            int picturesInAlbum = 20;
            int allPictures = 480;
            int albumsNeeded = allPictures / picturesInAlbum;
            Console.WriteLine(albumsNeeded + " albums will be needed");
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            Console.WriteLine("\nQ.48:");
            int tradingCards = 94;
            int fullBoxMax = 8;
            int boxsFilled = tradingCards / fullBoxMax;
            double unfilledbox = (double)(tradingCards % fullBoxMax);
            Console.WriteLine(boxsFilled +" boxes were filled and " + unfilledbox +" cards are in the unfilled box");
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            Console.WriteLine("\nQ.49:");
            int books = 210;
            int shelves = 10;
            int booksInShelves = books / shelves;
            Console.WriteLine(booksInShelves + " books will be in each shelf");
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            Console.WriteLine("\nQ.50:");
            int cristinaCroissants = 17;
            int guests = 7;
            int croissantPerGuest = cristinaCroissants / guests;
            Console.WriteLine("Each guest will have be served with " + croissantPerGuest + " croissant");
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

        }
    }
}
