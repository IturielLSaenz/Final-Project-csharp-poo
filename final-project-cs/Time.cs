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
    public void incrementHour(int increment){
        if (this.Hour+increment>=24){
            this.Hour=00;
            this.Hour+=increment-1;
        }
    }
    public void incrementMinute(int increment){
        if(this.Minute+increment>=60){
            this.Minute=00;
            this.Minute+=increment-1;
            this.incrementHour(1);
        }
    }
    public void incrementSecond(int increment){
        if(this.Second+increment>=60){
            this.Second=00;
            this.Second+=increment-1;
            this.incrementMinute(1);
        }
    }
    public string toString(){
        return $"{Hour}:{Minute}:{Second}";
    }
}