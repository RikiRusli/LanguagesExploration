using System;
// 
// 1. Cara mendifinisikan kelas
class PublicClass {
    // 2. Cara mendefinisikan atribut privat bertipe int
    // Atribut untuk menyimpan data integer*/
    private int privateInt;
    
    // 3. Cara mendifinisikan atribut public bertipe string, dan mengisi dengan nilai awal
    public String publicString = "Hello";
    
    // 4. Cara mendefinisikan atribut statik
    public static int staticInt;
    
    // 5. Cara mendefinisikan konstanta
    public const double PI = 3.14;
    
    // 6. Cara mendefinisikan konstruktor
    public PublicClass() {
        // kosong
    }
    
    // 7a. Cara mendefinisikan method dengan parameter tanpa return value
    // 7b. Cara menuliskan dokumentasi untuk method 7a
    ////<summary>
    ///komentar yang muncul di kolom deskripsi
    ///</summary>
    ///<remarks>
    ///penjelasan untuk method setPrivateInt di bagian remark
    ///</remarks>
    public void SetPrivateInt(int privateInt) {
        this.privateInt = privateInt;
        // 8. Cara mengisi atribut dari dalam kelas itu sendiri
        this.privateInt = privateInt;
    }
    
    // 9a. Cara mendefinisikan method dengan return value
    // 9b. Cara menuliskan dokumentasi untuk method 9a
    /*Mendapatkan nilai dari atribut privateInt
    @return nilai dari privateInt*/
    ///<summary>
    ///komentar yang muncul di kolom deskripsi
    ///</summary>
    ///<remarks>
    ///penjelasan untuk method getPrivateInt di bagian remark
    ///</remarks>
    public virtual int GetPrivateInt() {
        
        // 10. Cara mengembalikan nilai
        return this.privateInt;
    }
}

// 11. Cara menurunkan kelas
class PublicSubClass : PublicClass {
    
    // 12. Cara melakukan override method
    public override int GetPrivateInt() {
    
        // 13. Cara mengakses method pada superclass
        return 2 * base.GetPrivateInt();
    }
}

public class LanguagesExploration {
    
    public static void Main(String[] args) {
        // 14. Cara menginstansiasi kelas baru
        PublicClass publicClass = new PublicClass();
        
        // 15. Cara memanggil method dengan parameter
        // Memanggil method berparameter yakni "public void setPrivateInt(int privateInt)"
        // Dengan masukan angka 13
        publicClass.SetPrivateInt(13);
        
        // 16. Cara memanggil method dan mendapatkan return value-nya
        Console.WriteLine("[13] publicClass.GetPrivateInt() = " + publicClass.GetPrivateInt());
        
        // 17. Cara mengubah isi atribut publik dari luar kelas
        publicClass.publicString = "World!";
        
        // 18. Cara mendapatkan isi atribut publik dari luar kelas
        Console.WriteLine("[World!] publicClass.publicString = " + publicClass.publicString);
        
        // 19. Cara mengisi nilai atribut statik
        PublicClass.staticInt = 10;
        
        // 20. Cara mendapatkan nilai atribut statik
        Console.WriteLine("[10] PublicClass.staticInt = " + PublicClass.staticInt);
        
        // 21. Cara mendapatkan nilai konstanta
        Console.WriteLine("[3.14] PublicClass.PI = "+PublicClass.PI);
        
        // 22. Cara menginstansiasi kelas dengan turunannya
        PublicClass publicSubClass = new PublicSubClass();
        
        publicSubClass.SetPrivateInt(13);
        
        // 23. Memastikan method overriding bekerja
        Console.WriteLine("[26] publicSubClass.GetPrivateInt() = {0}", publicSubClass.GetPrivateInt());
    }
}
