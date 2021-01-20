# Altin-Bulma-Oyunu

### Kurulum
1. proje clone edilerek ya da indirilerek Visual Studio ile açılabilir.


### Oyunun Açıklaması

* Oyun 4 oyuncu ile oynanmaktadır.
* Oyun özdeş karelerden oluşan ve dinamik olarak boyutu belirlenebilen dikdörtgen bir tahta üzerinde gerçekleştirilecektir (varsayılan boyutlar: 20x20 kare).
* Her bir oyuncu tahtanın ayrı bir köşesinden oyuna başlar.
* Tahtadaki karelerin bir kısmında altın bulunacaktır. Altınlar Karelere rastgele dağılmalı ve altın bulunan kare sayısı toplam kare sayısının belli bir oranında olmalıdır. (Varsayılan olarak %20. Örneğin 400 kare için rastgele 80 kare). Altınların bulunduğu karelerin de varsayılan %10’unda gizli altın bulunacaktır bu altınları başlangıçta oyuncular göremeyecektir.
* Altın bulunan her bir karedeki altın miktarı 5’in katlarından (5 ile 20 arasında) herhangi biri
olabilir.
* Her kullanıcı sırayla hamle yaparak oyunu oynayacaktır.
* Bir oyuncu altın bir karenin üzerinden geçtiğinde altını alacaktır.
* Her kullanıcının başlangıçta eşit ve belli bir miktar altını bulunmaktadır (varsayılan 200 altın).
* Altını biten oyuncu elenmektedir.
* Oyun tüm oyuncuların altını bittiğinde veya karelerde altın tamamen tükendiğinde bitecektir.
* Her oyuncu bir seferde ileri geri ya da sağ sol şeklinde hareket edebilir. Her hamlede belli bir adım sayısı kadar hareket edebilecektir (varsayılan 3 adım).
* Sırası gelen oyuncular ilk başta gideceği altını tespit etmeleri gerekmektedir. Her hedef
belirlemenin bir maliyeti vardır ve her oyuncu için bu maliyet değişmektedir. Oyuncular hedefi olmadan hamle yapmamalıdır. Oyunda yeniden hedef belirmeyi gerektiren üç durum
bulunmaktadır.
Birinci durum: Oyuncu hedeflediği altına ulaşmıştır ve bir sonraki alacağı altını 
hedeflemesi gerekir.
İkinci durum:
Başka bir oyuncu hedeflenen altını kapmıştır bu yüzden başka bir altın hedefi belirlenmelidir. 
Üçüncü durum: 
Oyunun başında oyuncuların herhangi bir hedefi olmadığı için adım atmadan önce bir altını hedeflemelidir.
### A oyuncusu:
Kendine en yakın uzaklıktaki altını hedefler. Her hamle varsayılan 5, her hedef belirleme varsayılan 5 altın maliyetindedir.
### B oyuncusu:
En karlı olan altın kareyi hedefler. Altının uzaklığı ve altın miktarını dikkate alarak hedefini belirler. Her hamle varsayılan 5, her hedef belirleme varsayılan 10 altın
maliyetindedir.
### C oyuncusu:
Her hedef belirleme öncesinde kendisine en yakın belli sayıdaki gizlenmiş altınların olduğu kutuları açar. Bu açılan altınlarla birlikte tüm altınlar içerisinden B oyuncusu
gibi en karlı olanı hedefler. Her hamle varsayılan 5, her hedef belirleme varsayılan 15 altın maliyetindedir.
### D oyuncusu:
Diğer oyuncuların yapacağı hamleleri önceden sezme yeteneği bulunur. Diğer oyuncuların hedeflediği altınlara onlardan önce erişemiyorsa bu altınları hariç tutar ve hedef
olarak diğer altın kareler içerisinden en karlı olanı seçer. Her hamle varsayılan 5, her hedef belirleme varsayılan 20 altın maliyetindedir.
* Yukarıdaki varsayılan olarak belirlenen tüm özellikler bir parametre şeklinde tanımlanmalı ve istendiğinde oyun başlamadan önce bu değerler değiştirilebilmelidir.
* Bir oyuncunun gizli altınlardan birinin üzerinden geçmesi durumunda bu altın kare açılarak oyunculara görünür hale gelir. Ancak bu altının alınabilmesi için ikinci bir defa üstünden geçilmesi gerekmektedir.
* Bir oyuncunun hedeflediği altın başka bir oyuncu tarafından alınırsa oyuncunun yeni bir hedef
belirlemesi gerekmektedir

