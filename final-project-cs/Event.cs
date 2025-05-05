/*
    Class Event, que integra los objetos Person,Time y Date, para crear
    un evento.
    Autor: Ituriel Liebes Sáenz
*/
public class Event{
    // atributos de la clase Event
    protected Person contact = new Person();
    protected Date fecha = new Date();
    protected Time timeStart = new Time(),timeEnd = new Time();
    protected string subject,desc;
    /*
        constructor:
    */
    public Event(Person contact, Date fecha, Time timeStart, Time timeEnd, string subject = "n/a", string desc = "n/a"){
        this.Contact=contact;
        this.Fecha=fecha;
        this.TimeStart=timeStart;
        this.TimeEnd=timeEnd;
        this.Subject=subject;
        this.Desc=desc;
    }
    //  Setters y getters:
    public Person Contact{
        set{
            this.contact = value;
        }get{return this.contact;}
    }
    public Date Fecha{
        set{
            this.fecha = value;
        }get{return this.fecha;}
    }
    public Time TimeStart{
        set{
            this.timeStart=value;
        }get{return this.timeStart;}
    }
    public Time TimeEnd{
        set{
            this.timeEnd=value;
        }get{return this.timeEnd;}
    }
    public string Subject{
        set{
            this.subject = value;
        }get{return this.subject;}
    }
    public string Desc{
        set{
            this.desc=value;
        }get{return this.desc;}
    }
    public string toString(){
        return $"Asunto: {Subject} | Fecha: {Fecha} | Hora Inicio: {TimeStart} | Hora Fin: {TimeEnd} | Desc: {Desc}";
    }
}