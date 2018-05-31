using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CheckCar.Models
{
    public class CheckCarInitializer : DropCreateDatabaseIfModelChanges<CheckCarContext>
    {
        protected override void Seed(CheckCarContext context)
        {
            var markalar = new List<Mark>()
            {
                new Mark(){ MarkName="Alfa Romeo",MarkImage="alfa-romeo.png"},
                new Mark(){ MarkName="Aston Martin",MarkImage="aston-martin.png"},
                new Mark(){ MarkName="Audi",MarkImage="audi.png"},
                new Mark(){ MarkName="Bentley",MarkImage="bentley.png"},
                new Mark(){ MarkName="BMW",MarkImage="bmw.png"},
                new Mark(){ MarkName="Chadillac",MarkImage="cadillac.png"},
                new Mark(){ MarkName="Chery",MarkImage="chery.png"},
                new Mark(){ MarkName="Chevrolet",MarkImage="chevrolet.png"},
                new Mark(){ MarkName="Chrysler",MarkImage="chrysler.png"},
                new Mark(){ MarkName="Citroen",MarkImage="citroen.png"},
                new Mark(){ MarkName="Dacia",MarkImage="dacia.png"},
                new Mark(){ MarkName="Daewo",MarkImage="daewoo.png"},
                new Mark(){ MarkName="Daihatsu",MarkImage="daihatsu.png"},
                new Mark(){ MarkName="DFM",MarkImage="dfm.png"},
                new Mark(){ MarkName="Dodge",MarkImage="dodge.png"},
                new Mark(){ MarkName="Ferrari",MarkImage="ferrari.png"},
                new Mark(){ MarkName="Fiat",MarkImage="fiat.png"},
                new Mark(){ MarkName="Ford",MarkImage="ford.png"},
                new Mark(){ MarkName="Geely",MarkImage="geely.png"},
                new Mark(){ MarkName="Honda",MarkImage="honda.png"},
                new Mark(){ MarkName="Hyundai",MarkImage="hyundai.png"},
                new Mark(){ MarkName="Infiniti",MarkImage="infiniti.png"},
                new Mark(){ MarkName="Isuzu",MarkImage="isuzu.png"},
                new Mark(){ MarkName="Jaguar",MarkImage="jaguar.png"},
                new Mark(){ MarkName="Jeep",MarkImage="jeep.png"},
                new Mark(){ MarkName="Kia",MarkImage="kia.png"},
                new Mark(){ MarkName="Lada",MarkImage="lada.png"},
                new Mark(){ MarkName="Lamborghini",MarkImage="lamborghini.png"},
                new Mark(){ MarkName="Lancia",MarkImage="lancia.png"},
                new Mark(){ MarkName="Land Rover",MarkImage="land-rover.png"},
                new Mark(){ MarkName="Lexus",MarkImage="lexus.png"},
                new Mark(){ MarkName="Maserati",MarkImage="maserati.png"},
                new Mark(){ MarkName="Mazda",MarkImage="mazda.png"},
                new Mark(){ MarkName="Mercedes",MarkImage="mercedes.png"},
                new Mark(){ MarkName="Mini",MarkImage="mini.png"},
                new Mark(){ MarkName="Mitsubishi",MarkImage="mitsubishi.png"},
                new Mark(){ MarkName="Nissan",MarkImage="nissan.png"},
                new Mark(){ MarkName="Opel",MarkImage="opel.png"},
                new Mark(){ MarkName="Peugeot",MarkImage="peugeot.png"},
                new Mark(){ MarkName="Porsche",MarkImage="porsche.png"},
                new Mark(){ MarkName="Proton",MarkImage="proton.png"},
                new Mark(){ MarkName="Renault",MarkImage="renault.png"},
                new Mark(){ MarkName="Rover",MarkImage="rover.png"},
                new Mark(){ MarkName="Saab",MarkImage="saab.png"},
                new Mark(){ MarkName="Seat",MarkImage="seat.png"},
                new Mark(){ MarkName="Skoda",MarkImage="skoda.png"},
                new Mark(){ MarkName="Smart",MarkImage="smart.png"},
                new Mark(){ MarkName="SsangYong",MarkImage="ssangyong.png"},
                new Mark(){ MarkName="Subaru",MarkImage="subaru.png"},
                new Mark(){ MarkName="Suzuki",MarkImage="suzuki.png"},
                new Mark(){ MarkName="Tata",MarkImage="tata.png"},
                new Mark(){ MarkName="Tofaş",MarkImage="tofas.png"},
                new Mark(){ MarkName="Toyota",MarkImage="toyota.png"},
                new Mark(){ MarkName="Volkswagen",MarkImage="volkswagen.png"},
                new Mark(){ MarkName="Volvo",MarkImage="volvo.png"}
            };

            foreach (var marka in markalar)
            {
                context.Marks.Add(marka);
            }
            context.SaveChanges();

            var modeller = new List<MarkVersion>()
            {
                new MarkVersion(){ VersionName="Giulietta",MarkID=1,VersionImage="giulietta.jpg"},
                new MarkVersion(){ VersionName="Giulia",MarkID=1,VersionImage="giulia.jpg"},
                new MarkVersion(){ VersionName="4C",MarkID=1,VersionImage="4c.jpg"},
                new MarkVersion(){ VersionName="Stelvio",MarkID=1,VersionImage="stelvio.jpg"},
                new MarkVersion(){ VersionName="156",MarkID=1,VersionImage="156.jpg"},
                new MarkVersion(){ VersionName="MiTo",MarkID=1,VersionImage="mito.jpg"},
                new MarkVersion(){ VersionName="159",MarkID=1,VersionImage="159.jpg"},
                new MarkVersion(){ VersionName="145",MarkID=1,VersionImage="145.jpg"},
                new MarkVersion(){ VersionName="146",MarkID=1,VersionImage="146.jpg"},
                new MarkVersion(){ VersionName="147",MarkID=1,VersionImage="147.jpg"},
                new MarkVersion(){ VersionName="155",MarkID=1,VersionImage="155.jpg"},
                new MarkVersion(){ VersionName="164",MarkID=1,VersionImage="164.jpg"},
                new MarkVersion(){ VersionName="166",MarkID=1,VersionImage="166.jpg"},
                new MarkVersion(){ VersionName="Brera",MarkID=1,VersionImage="brera.jpg"},
                new MarkVersion(){ VersionName="GT",MarkID=1,VersionImage="gt.jpg"},
                new MarkVersion(){ VersionName="GTV",MarkID=1,VersionImage="gtv.jpg"},
                new MarkVersion(){ VersionName="Spider",MarkID=1,VersionImage="spider.jpg"},
                new MarkVersion(){ VersionName="33",MarkID=1,VersionImage="33.jpg"},
                new MarkVersion(){ VersionName="75",MarkID=1,VersionImage="75.jpg"},
            };
            foreach (var model in modeller)
            {
                context.MarkVersions.Add(model);
            }
            context.SaveChanges();

            var arabaDetaylari = new List<CarDetail>()
            {
                new CarDetail(){ CarName="2018 1.4 Süper TCT"},
                new CarDetail(){ CarName="2018 16 JTD Progression TCT"},
                new CarDetail(){ CarName="2018 1.6 JTD Progression" },
                new CarDetail(){ CarName="2018 1.6 JTD Süper TCT"},
            };
            foreach (var arabadetay in arabaDetaylari)
            {
                context.CarDetails.Add(arabadetay);
            }
            context.SaveChanges();

            var haberler = new List<News>()
            {
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C5", NewsImage="Haber5",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C6", NewsImage="Haber6",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C7", NewsImage="Haber7",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C8", NewsImage="Haber8",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C9", NewsImage="Haber9",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C1", NewsImage="Haber1",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C", NewsImage="Haber",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},
                new News(){Date=System.DateTime.Now, NewsBaslik="Yeni Citröen C4", NewsImage="Haber4",NewsIcerik="Avrupanın en hızlı büyüyen C-SUV segmentinin yeni temsilcisi Citroen C5 Aircross Fransa'da tanıtıldı. Güncel C3 Aircross ile benzer tasarıma sahip olan Yeni C5 Aircross, yanlarda bulunan airbump tasarımları ile C4 Cactus modelinden de izler taşıyor.7 ana gövde rengi ile farklı renklerde kombine edilebilen tavan renkleri ve 5 farklı iç mekan rengiyle tamamen kişiselleştirilebilir seçenekler sunan C5 Aircross, ana hatlarıyla alışılagelmiş Citroen çizgileri taşıyor. 720 litrelik devasa bagaj hacmi arka koltukları yatırıldığında 1630 litreye ulaşabiliyor. Bu veriler aracın segmentindeki en geniş bagaj hacmine sahip olduğunu gösteriyor.Yeni C5 Aircross modelinde görev yapacak olan 2 benzinli ve 3 dizel motor seçeneğine sahip Euro 6.2 normlarındaki motorlar 130 ve 180 beygir güç üretecek. 6 ileri manuel ve Aisin imzalı 8 ileri tam otomatik şanzıman sistemleri bu motorlara eşlik edecekler.Yeni Citroen C5 Aircross özellikle Uçan Halı sloganı ile konfor konusunda oldukça iddialı. Citroen tarafından patenti yeni alınan çift hidrolik sisteme sahip süspansiyonlar tamamen konfor odaklı bir sürüş deneyimi sağlamak için geliştirilmiş.12,3 inç boyutundaki yeni sürücü gösterge paneli ile Android Auto ve Apple Car Play destekli 8 inçlik multimedya ekranı modeldeki yerini alacak. Multimedya sistemi Citroen Connect Nav adı verilen 3D navigasyon yazılımı da taşıyor. Ayrıca araçta akıllı telefonlara özel kablosuz şarj ünitesi de bulunuyor. Yeniden geliştirilen Grip Kontrol sistemi ise otomatik olarak sürüş deneyimini düzenleyecek.Yeni Citroen C5 Aircross modelinin bir başka ilgi çekici donanımlarından biri olan ve ConnectCAM adı verilen yeni teknolojisi ise dikiz aynasında yer alan ve 16 GB bir belleğe sahip olan bir kamera. Bu kamera istendiğinde yüksek çözünürlüğe sahip fotoğraflar çekerek, çektiği fotoğrafları kayıtlı cep telefonlarına ya da email adreslerine gönderebiliyor.Resmi olarak 2019 yılında hibrit versiyonunun da hazırlanacağının açıklanması Citroen C5 Aircross modeli için markanın uzun bir ömür biçtiğinin bir göstergesi olarak yorumlanıyor. Citroen'in Fransa fabrikasında üretilecek olan modelin bu yılın sonlarına doğru Avrupa pazarında satışa sunulması bekleniyor."},



            };
            foreach (var haber in haberler)
            {
                context.News.Add(haber);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}