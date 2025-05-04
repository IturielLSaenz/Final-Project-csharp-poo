/*
    Class Date, donde se maneja la creación de objetos "Fecha"
    Autor: Ituriel Liebes Saenz
*/
using System;
public class Date{
    private int d,m,y;
    public Date(int d=1, int m=1,int y=1970){
        this.Day=d;
        this.Month=m;
        this.Year=y;
    }
    /*
        Hacemos primero el setter del año
        así es más facil calcular si se trata de un año bisiesto
        y poder asignar los valores del día con mejores condiciones!
    */
    public int Year{
        set{
            this.y = value>=1970 ? value:1970;
        }get{return this.y;}
    }
    public int Month{
        set{
            this.m = (value>0 && value<=12) ? value:1;
        }get{return this.m;}
    }
    public int Day{
        set{
            // logica para ingresar el dia
            int limit = getLimitDay();
            // asignar el valor:
            if(value<=limit){
                this.d = value;
            }else{
                Console.WriteLine("No es un valor válido para el día en ese mes y año!");
            }
        }get{return this.d;}
    }
    // metodos para incrementar y decerementar los atributos:
        public void inrementYear(){
        this.Year +=1;
    }
        public void incrementMonth(){
        if(Month+1>12){
            Month=1;
            inrementYear();
        }
    }
    public void incrementDay(){
        int limit = getLimitDay();
        if(Day+1>limit){
            Day=1;
            incrementMonth();
        }else{
            Day+=1;
        }        
    }
    public void decrementYear(){
        if(Year-1>=1970){
            Year-=1;
        }else{
            Console.WriteLine("No puedes disminuir más el año!");
        }
    }
    public void decrementMonth(){
        if(Month-1>=1){
            Month-=1;
        }else{
            Month=1;
            decrementYear();
        }
    }
    public void decrementDay(){
        int limit = getLimitDay();
        if(Day-1<=limit){
            Day-=1;
        }else{
            Day=1;
            decrementMonth();
        }
    }
    public bool isLeapYear(){
        return Year%4==0 && (Year%100!=0 || Year%400==0);
    }
    public int getLimitDay(){
        int limit;
        if (Array.Exists(new int[] { 1, 3, 5, 7, 8, 10, 12 }, month => month == this.Month)){
            limit = 31;
        }else if(Array.Exists(new int[] {4,6,9,11}, month => month == this.Month)){
            limit = 30;
        }else{
            if (isLeapYear()){
                limit = 29;
            }else{
                limit = 28;
            }
        }
        return limit;
    }
    /*
        Metodo toString para el display del objeto:
    */
    public string toString(){
        return $"{Day}/{Month}/{Year}";
    }
}