/*
    Class Time, que permite crear un objeto Tiempo para manejar la agenda
    con más detalle!
    Autor: Ituriel Liebes Saenz
*/
using System;
public class Time{
    private int hour,minute,second;
    public Time(int hour,int minute,int second){

    }
    //setters & getters:
    public int Hour{
        set{
            if(value>0 & value<=12){
                this.hour=value;
            }
        }get{return this.hour;}
    }
    public int Minute{
        set{
            // codigo logica para el setter del minuto!
        }get{return this.minute;}
    }
    public int Second{
        set{
            // codigo logica para el setter del segundo!
        }get{return this.second;}
    }
}