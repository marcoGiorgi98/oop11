using System;



namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        
        public Complex(int num , double imma)
        {
            this.Number=num;
            this.Immaginary=imma;

        }
        public int Number { get;} 
        
        public double Immaginary {get;}
           
        public double Modul => Math.Sqrt(Number*Number + Immaginary*Immaginary);

        public double Phase => Math.Atan2(Number , Immaginary);

        public string Segno(double im)
        {       
            
            if (Math.Sign(Immaginary)==-1)
            {
                return "-";
            }
            if(Math.Sign(Immaginary)==1)
            {
                return "+";
            }
            return "";
        }
        

        public string Completo => Convert.ToString(Number) + Segno(Immaginary) + Convert.ToString(Immaginary) + "i";

        public Complex Sum(int a, int b, int c ,int d)
        {
          return new Complex(a+c, b+d);
        }        
        // TODO: fill this class\
    }
}