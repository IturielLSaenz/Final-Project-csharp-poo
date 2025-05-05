/*
    Class agenda, integra todas las clases.
    Autor: Ituriel Liebes Sáenz
*/
using System;
using System.Collections;
public class Agenda{
    protected Person owner = new Person("N/A", "N/A", "N/A");
    protected ArrayList eventos = new ArrayList();
    public Agenda(Person owner){
        this.Owner=owner;
    }
    public Person Owner{
        set{
            this.owner=value;
        }get{
            return this.owner;
        }
    }
    public void addEvent(Event evento){
        if(evento!=null){
            eventos.Add(evento);
        }else{
            Console.WriteLine("No puedes añadir un evento vacío!");
        }
    }
    public void removeEvent(int index){
        if(eventos[index]!=null){
            eventos.RemoveAt(index);
        }else{
            Console.WriteLine("No hay un evento para eliminar!");
        }
    }
}