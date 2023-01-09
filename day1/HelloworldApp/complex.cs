// public class complex{
//     public int real;
//     public int imag;

//    //defaut constr
//     public Complex()
//     {
//         real=0;
//         imag=0;
//     }
//     //paramertized constr
//     public Complex(int r,int i)
//     {
//         this.real=r;
//         this.imag=i;
//     }

//     //property of getter and setter
//     public int Real
//     {
//         get{return this.real;}
//         set{this.real=Value;}
//     }
//      public int Imag
//     {
//         get{return this.real;}
//         set{this.real=Value;}
//     }

//     //all arethimatic operators can be overloaded 
//     public static Complex operator+(Complex c1 , Complex c2)
//     {
//         Complex temp = new Complex();
//         temp.Real = c1.Real + c2.Real;
//         temp.Imag = c1.Imag + c2.Imag;
//         return temp;
//     }

// }

public class Complex {
    private int real;
    private int imag;

    public Complex(){
        this.real=0;
        this.imag=0;
    }
    public Complex(int r, int i){
        this.real=r;
        this.imag=i;
    }

    //Property
    public int Real{
        get{return this.real;}
        set{this.real=value;}
    }
    public int Imag{
        get{return this.imag;}
        set{this.imag=value;}
    }

    //Operator overloading
    //all arithmatic operators can be overloaded
    public static Complex  operator+ (Complex c1, Complex c2){
        Complex temp=new Complex();
        temp.Real=c1.Real + c2.Real;
        temp.Imag=c1.Imag + c2.Imag;
        return temp;
        Console.WriteLine("done");
    }
}