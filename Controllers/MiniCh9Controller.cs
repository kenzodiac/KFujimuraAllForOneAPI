using Microsoft.AspNetCore.Mvc;

namespace KFujimuraAllForOneAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh9Controller : ControllerBase
{
    [HttpGet]
    [Route("RestaurantPicker/{category}")]

    public string RestaurantPicker(string category){
        //input validation
        int catInt = 0;
        bool isValid = Int32.TryParse(category, out catInt);
        
        //rng
        Random rnd = new Random();

        //variables for helping to pick restaurants
        int output = 0;
        bool errorMsg = false;

        //string array that holds all restaurant names
        string[] restaurantList = {
        //Lodi Restaurants = index 0-9:
        "Komachi Sushi",
        "Dumpling House In Lodi",
        "Fiori’s Butcher Shoppe & Deli",
        "Hazumi Sushi Bar and Japanese Cuisine",
        "Thai Kitchen",
        "Zin Bistro",
        "Yen Ching Restaurant",
        "Friends Indian Restaurant",
        "La Campana Taqueria",
        "Rick's New York Style Pizza",

        //Stockton Restaurants = index 10-19:
        "Seoul Soon Dubu Tofu House",
        "Tasty Pot",
        "Jitaro Truck",
        "Tandoori Nites",
        "German Guys",
        "Bonchon",
        "Cocoro Japanese Bistro & Sushi Bar",
        "Yen Du Restaurant",
        "Green Papaya",
        "Mama's Pho & Sandwiches",

        //Fast Food Restaurants = index 20-29:
        "Raising Canes",
        "In-N-Out Burger",
        "Luu’s Chicken Bowl",
        "El Pollo Loco",
        "Chipotle Mexican Grill",
        "The Habit Burger Grill",
        "Panera Bread",
        "Fire Wings",
        "Mr Pickle's Sandwich Shop",
        "Fosters Freeze"
        };
        
        //if statement checking to see if the input was valid
        if (isValid == false) {
            errorMsg = true;

        //else statement with switch statements to continue with rest of program if input is valid
        } else {
            switch (catInt){
                case 1:
                    output = rnd.Next(0,10);
                    errorMsg = false;
                    break;
                case 2:
                    output = rnd.Next(10,20);
                    errorMsg = false;
                    break;
                case 3:
                    output = rnd.Next(20,30);
                    errorMsg = false;
                    break;
                case 4:
                    output = rnd.Next(0,30);
                    errorMsg = false;
                    break;
                default:
                    errorMsg = true;
                    break;
            }
        }

        //function returns to provide user with program output
        if (errorMsg == true){
            return "Error: Please input a whole number between 1 and 4.\n\n1 = Pick a restaurant in Lodi\n\n2 = Pick a restaurant in Stockton\n\n3 = Pick a fast food restaurant\n\n4 = Pick any type of restaurant";
        } else {
            return $"You should eat at \"{restaurantList[output]}\". Bon appetit!";
        }
    }
}
