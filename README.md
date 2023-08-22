# Design Patterns

 Bu proje, Çasgem tarafından düzenlenen eğitmenliğini [Murat YÜCEDAĞ](https://www.udemy.com/user/murat-yucedag-3/) hocamızın yaptığı Full Stack .Net Development eğitimi kapsamında
 yapılmıştır.Projede 4 tane design pattern kullanılarak konunun anlaşılması için herbiri için ayrı proje oluşturulmuştur.

## Chain Of Responsibility Design Pattern

Chain of Responsibility (Sorumluluk Zinciri), yazılım tasarım deseni olarak bilinen bir kavramdır. Bu desen, bir isteğin veya komutun bir dizi nesne üzerinden 
işlenmesini sağlayan bir yapıyı ifade eder. Her bir nesne, isteği işlemeye yetkili olup olmadığını kontrol eder ve işlemesi gerekiyorsa işlemi gerçekleştirir 
veya zincirde sonraki nesneye ileterek işlem zincirini sürdürür.

Bu desenin temel amacı, isteğin hangi nesnenin işleyeceğini önceden belirlemek yerine, nesneleri bir zincirde bağlayarak isteğin otomatik olarak doğru nesne tarafından 
işlenmesini sağlamaktır. Böylece istemci kodunun nesneler arasındaki bağımlılığı azalır ve nesnelerin yeniden kullanılabilirliği artar.
### Örnek Proje
Örnek projemizde bir bankayı simüle ettik. Bankada 4 adet çalışan ve herbirinin günlük ödeme limitini tanımladık. Müşteri çekmek istediği miktarı girip butona bastığında 
arka planda Chain Of Responsibility
yardımıyla işlemi kolaylıkla gerçekleştirdik.

![](https://i.hizliresim.com/9b1w7dc.png)
------------
![](https://i.hizliresim.com/305zddh.png)
------------

## CQRS Design Pattern

CQRS (Command Query Responsibility Segregation), yazılım tasarımında kullanılan bir desen veya yaklaşımdır. Bu yaklaşım, veri tabanı işlemlerini (komutlar) 
ve veri sorgulamalarını (sorgular) farklılaştırarak işlemeyi amaçlar. Geleneksel olarak, bir uygulama hem veri güncelleme işlemleri (komutlar) hem de veri 
sorgulamaları (sorgular) için aynı veri modelini kullanırken, CQRS bu iki işlem türünü farklı veri modelleri üzerinde işlemeye olanak tanır.

### Örnek Proje
Örnek projemizde CQRS kullanarak Sql veritabanına ürün ekleme , silme , güncelleme , id'ye göre getirme işlemlerini gerçekleştirdik.

![](https://i.hizliresim.com/e4bvdg2.png)
------------
![](https://i.hizliresim.com/l1nb13a.png)
------------

## Mediator Design Pattern

Mediator tasarım deseni, nesneler arasındaki iletişimi düzenlemek ve merkezi bir iletişim noktası sağlamak için kullanılan bir yazılım tasarım desenidir. 
Bu desen, karmaşık sistemlerdeki nesnelerin birbirleriyle doğrudan iletişim kurmasını azaltarak, sistemin daha sıkı bağlılıklardan kaçınmasına ve daha esnek 
hale gelmesine yardımcı olur. CQRS ile birlikte kullanıldığında da kolaylık sağlar.


### Örnek Proje
Örnek projemizde Mediator design patternini CQRS ile birlikte kullanarak CQRS'te controller kısmında yaşanan constructor kalabalığını mediator aracılığıyla en aza indirip
daha doğru bir kullanım gerçekleştirdik.

![](https://i.hizliresim.com/mvzpoua.png)
------------
![](https://i.hizliresim.com/ha5zb99.png)
------------

## Observer Design Pattern

Observer tasarım deseni, bir nesnenin durumunda meydana gelen değişiklikleri diğer nesnelere otomatik olarak bildiren ve böylece bağımlılıkları minimize eden 
bir yazılım tasarım desenidir. Bu desen özellikle bir nesnenin durumu değiştiğinde bununla ilişkili diğer nesnelerin güncellenmesi 
gerektiği durumlarda kullanılır.


### Örnek Proje
Örnek projemizde sisteme bir kullanıcı kayıt olduğunda kendisine hoşgeldiniz mesajı gitmesini daha sonrasında kayıt olan her kullanıcıya indirim kuponu tanımlanmasını ve kullanıcının seçtiği dergi 
sisteme eklendiğinde kullanıcıya bilgilendirme yapılması durumunu simüle ettik.


## 🔗 Contact with me:

[<img  align="left" width="40" src="https://i.hizliresim.com/exri7bb.png"  />][instagram]
[<img  align="left" width="40" src="https://i.hizliresim.com/f1rgvb3.png"  />][twitter]
[<img align="left"  width="40" src="https://i.hizliresim.com/3hvivrs.png"  />][linkedin]
[<img  align="left" width="40" src="https://i.hizliresim.com/9nz06zq.png"  />][gmail]

[instagram]: https://www.instagram.com/ugurfurkan64/
[twitter]: https://twitter.com/Furkanugur64
[linkedin]: https://www.linkedin.com/in/furkan-ugur64/
[gmail]: mailto:furkanugur64@gmail.com




