

using System.Data;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public class Balloon
    {
        private string colour;
        //private decimal height;
        private decimal diameter;

       

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                if(value.ToUpper()=="RED"|| value.ToUpper() == "BLUE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Color must be red or blue");
                }
                
            }
        }
        public string BaloonName { get; set; }

        public decimal Height
        {
            get;

            set;
           
        }

        public decimal Diamiter
        {   
            
            get
            {
                return diameter;
            }
            set
            {
                //if(colour != string.Empty)
                if(string.IsNullOrEmpty(colour))
                {

                    if (colour.ToUpper() == "BLUE")
                    {
                        
                        if (diameter <= 5)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("blue baloon must be less than or equal to 5");
                        }

                    }
                    else if ( colour.ToUpper() == "RED")
                    {
                        if(diameter >= 12)
                        {
                            diameter = value;
                        }
                        else
                        {
                            throw new ConstraintException("Red baloon must be more ten or equal to 12");
                        }

                    }

 
                }
                else
                {
                    throw new DataException("The color must be set first");
                }
                
            }
        }


    }
}
