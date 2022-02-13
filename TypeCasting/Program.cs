byte b = 200;
int a = b;

//veya

a = b;


// TypeCasting (dönüşüm)
// TypeCastin'de kural tipler eşit olmalıdır. Tam sayı mesela
// 1) implicit (kapalı dönüşüm) otomatik dönüşümdür. Küçük tipin büyük tipe atanma işlemidir.

// byte > short > int > long > float > decimal > double

// 2) explicit
// açık dönüşüm büyüğün küçüğe dönüşümüdür.

float f = 100;
int i = 100;

byte j = (byte)i; // casting bu işlem
i = (int)f;

Console.WriteLine(i);
Console.WriteLine(j);


// Not: Type casting dikkatli kullanılması gerekir. Eğer değer cast edilen tip değer aralığından büyükse veri kaybı yaşanır.

sbyte sb;
int k = 257;
byte l = (byte)k;

Console.WriteLine(k); // normal hali
Console.WriteLine(l); // dönüştürülmüş hali

l = 128;
sb = (sbyte)l;

Console.WriteLine(l); // normal hali
Console.WriteLine(sb); // dönüştürülmüş hali -128 çıkar çünkü sbyte ın alabileceği en büyük değer 127'dir. 128 alırsa alabileceği en küçük değere döner ve o değerden artmaya başlar.

k = 515;
l = (byte)k;

Console.WriteLine(k); // normal hali
Console.WriteLine(l); // dönüştürülmüş hali

/* string ad = "1";
k = (int)ad; */ // dönüşüm işlemi geçersizdir, tiplerin ortak bir yanı yoktur.



