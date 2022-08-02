
# MissionProject

Bu proje Feysoft'un .Net ile oluşturulmuş değerlendirme projesidir. 


## Proje Tanımı

Bir işe alım sürecinin belirli kurallar çerçevesinde similasyon edilmesi beklenmektedir. 
İşe başvuracak kişinin bilgileri doldurulur (Statik veya Console’dan girilebilir). Bilgiler kontrol edilir ve bilgiler dahilinde ilgili sonuç döndürülür. 

İşe Başvuracak Kişinin Bilgileri :

-Yaş
-Teknolojiler
-T.C Kimlik Numarası
-Deneyim Yılı

Sonuçlar :

-AutoRejected
-TransferredToHR
-TransferredToLead
-TransferredToCTO
-AutoAccepted

Teknolojiler :
C# , HTML , JS , MSSQL , ALGORITHM , DATA STRUCTURE


  
## İşlemler
İşe başvuracak kişinin yaşı 18 den küçükse , Teknoloji Kullanım Yüzdesi %25 
den küçükse , Deneyim Yılı 1 yıldan küçükse ve T.C Kimlik Numarası uygun 
formatta değilse AutoRejected olarak başvuru sonuçlandırılmalıdır.

İşe başvuracak kişinin yaşı 18 den büyükse, Teknoloji Kullanım Yüzdesi %75 
den büyükse, Deneyim Yılı 1 yıldan büyükse ve T.C Kimlik Numarası uygun 
formattaysa AutoAccepted olarak başvuru sonuçlandırılmalıdır.

İşe başvuracak kişinin yaşı 18 den küçükse TransferredToHR olarak başvuru 
sonuçlandırılmalıdır.

İşe başvuracak kişinin Teknoloji Kullanım Yüzdesi 25 - 50 arasında ve Deneyim Yılı 1-2 yıl arasındaysa TransferredToLead olarak başvuru sonuçlandırılmalıdır.

İşe başvuracak kişinin Teknoloji Kullanım Yüzdesi 50- 75arasında ve Deneyim Yılı 2 yıldan büyükse TransferredToCTO olarak başvuru sonuçlandırılmalıdır.
 
 ! Teknoloji Kullanım Yüzdesi :

İşe başvuracak kişinin sahip olduğu teknolojiler üzerinden hesaplanır.
 
 ! T.C Kimlik Numarası :

11 hane ve sadece sayılardan oluşmalıdır. 10. sayı 1,3,5,7 ve 9. sayılarının top 
lamının 7 katı ile 2,4,6 ve 8 sayılarının toplamının 9 katını toplayın. Çıkan 
sonucunun birler basamağı 10.sayıya eşit olmalıdır.11.sayı 1,3,5,7 ve 9.sayılarının toplamının 8 katının birler basamağı olmalıdır.

## Proje Detayı

### Validator.cs
Bu sınıfta kullanıcıdan aldığımız değerlerin kontrolleri yapılıyor. Yaş sıfırdan küçük olamaz, Tc kimlik numarası 11 hane olmalıdır ve Deneyim yılı yaştan büyük olamaz gibi kontroller vardır.

### Applicant.cs
Başvuran sınıfıdır ve başvuran niteliklerini tutar.
```javascript
    public int Age { get; set; }
    public long IdentificationNumber { get; set; }
    public double YearsOfExperience { get; set; }
    public List<string> AvailableTech = new List<string>();
```
### ApplicantValidator.cs
Bu sınıfta İşlemlerde istenilen koşullar oluşturuldu. Tc kimlik numarası doğrulama, teknoloji kullanım yüzdesi hesaplama ve deneyim yılı kontrolleri yapıldı.
