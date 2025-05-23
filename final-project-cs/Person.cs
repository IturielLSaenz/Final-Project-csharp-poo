/*
    Clase Person - recibe atributos y crea un objeto "Persona"
    Especial para crear el contacto!
*/

using System;

public class Person{
    // Atributos:
    protected string name,tel,email;
    public Person(string name="n/a",string tel="n/a",string email="n/a"){
        this.Name=name;
        this.Tel=tel;
        this.Email=email;
    }
    public string Name{
        set{this.name=value;}get{return this.name;}
    }
    public string Tel{
        set{this.tel=value;}get{return this.tel;}
    }
    public string Email{
        set{this.email=value;}get{return this.email;}
    }
    public string toString(){
        return $"Nombre: {Name}, Telefono: {Tel}, Email: {Email}";
    }
}