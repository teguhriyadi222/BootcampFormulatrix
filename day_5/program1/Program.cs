class BangunRuang {
    private Segitiga _x;
    private Persegi _y;

    public BangunRuang(Segitiga x, Persegi y) {
        _x = x;
        _y = y;
    }

    public Persegi getPersegi() {
        return _y;
    }

    public Segitiga getSegitiga() {
        return _x;
    }
}

class Segitiga {
    private int tinggi;
    private int panjangAlas;

    public Segitiga(int tinggi, int panjangAlas) {
        this.tinggi = tinggi;
        this.panjangAlas = panjangAlas;
    }

    public int hitungLuas() {
        return (panjangAlas * tinggi) / 2;
    }
}

class Persegi {
    private int tinggi;
    private int panjang;

    public Persegi(int tinggi, int panjang) {
        this.tinggi = tinggi;
        this.panjang = panjang;
    }

    public int hitungLuas() {
        return tinggi * panjang;
    }
}

class Program {
    static void main() {
        Persegi persegi = new Persegi(5, 6);
        Segitiga segitiga = new Segitiga(1, 2);
        BangunRuang bangunRuang = new BangunRuang(segitiga, persegi);

        Persegi persegiBangunRuang = bangunRuang.getPersegi();
        int luasPersegi = persegiBangunRuang.hitungLuas();
        Console.WriteLine("Luas persegi: " + luasPersegi);

        Segitiga segitigaBangunRuang = bangunRuang.getSegitiga();
        int luasSegitiga = segitigaBangunRuang.hitungLuas();
        Console.WriteLine("Luas segitiga: " + luasSegitiga);
    }
}
