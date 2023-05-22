namespace day3;

class parents {
    public string name;

    private int age = 6;
    protected int angka = 0;

    
    public parents(string n) {
        name = n;
        Console.WriteLine("ini punya bapak");
    }

    public parents() {
        
    }

    public void methodparent(string n) {

        Console.WriteLine("orang tua");

    }
}

class child : parents {

    public string name;
    protected int umur;
    public child(string n): base(n) {
        name = n;
        Console.WriteLine("ini punya anak");
    }

    public void setUmur(int umur){
        this.umur = umur;   
    }

    public int getumur(){
        return umur;
    }



}

class anaktiri{

    public string angkat2;
    protected string kakak;
    public anaktiri(string n){
        Console.WriteLine("ini punya anak tiri");
    }

    public anaktiri() {
        Console.WriteLine("ini punya anak tiri");
    }


}

class anakbungsu : anaktiri{
    public string angkat;

    public anakbungsu(){
        
        
    }


}

