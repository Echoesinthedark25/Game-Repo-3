// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:

        Vector2 rectangleLocation = new Vector2(200, 800);
        Vector2 rectangleSize = new Vector2(200, 30);

        Vector2 circleLocation = new Vector2(200, 100);
        int circleRadius = 20;

        /// <summary>
        ///     Create the screen the game will be displayed on.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("My Game");
            Window.SetSize(900, 900);

        }

        /// <summary>
        ///     Create shapes.
        /// </summary>
        public void Update()
        {
            
            Draw.FillColor = Color.Red;
            Draw.Rectangle(rectangleLocation, rectangleSize);

            Draw.FillColor = Color.White;
            Draw.Circle(circleLocation, circleRadius);

            
            RectangleCollison();

        }

        //Create inputs
        public void Input ()
        {
            

        }
        
        //Create collison
        public void RectangleCollison ()
        {
            bool isColliding = circleLocation.Y + 10 >= 400f;

            if (isColliding == true)
            {
                
            }

        }
    }
}
