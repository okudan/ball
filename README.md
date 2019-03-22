# Top

**6. Ders**



  -	Başlamak için https://github.com/okudan/ball adresinden **‘Assets’** kasörünün içerisindekileri Unity'deki projenizin **‘Assets’** klasörü içine atın.
  -	Bu derste Unity içerisinde bir küreyi hareket ettirme kodu yazılacaktır. Unity’de objeler **‘Component’** adı verilen **‘Class’** ları içerisinde bulundurmaktadır. **‘Component’** lar tek başlarına veya bir arada çalışarak pozisyon, fizik, çizim, etkileşim gibi belirli görevleri yerine getiren parçalardır. Unity pek çok hazır **‘Component’** sunduğu gibi sıfırdan yazılmasına da izin vermektedir. Bu sayede istenilen her şeyin Unity içerisinde yapılması mümkün olmaktadır.
  
  -	**‘Top’** klasörü içerisindeki **‘Top’** adlı sahneyi açın. Buradaki **‘Top’** adlı objeye basarak **‘Inspector’** da sahip olduğu **‘Component’** ları inceleyin.   
  -	Geliştirmeniz için **‘Hareket’** adlı bir kod oluşturulmuş durumdadır. Kodu açarak inceleyin. Öncelikle alınan **‘Input’** u ekrana yazdırmak için gerekecek eklemeleri koda yapın. Ekrana yazdırma için Unity’nin UI sistemi kullanılacaktır. Bu sistemi kullanabilmek için kodun başına
	```
	using UnityEngine.UI;
	```
	satırını eklemeniz gerekmektedir. Ardından **public** olacak şekilde text objelerini **‘GameObject’** olarak tanımlayın ve bunları Unity’deki sahnede **‘Canvas’** içindeki **‘Horizontal’** ve **‘Vertical’** text objeleri ile bağlayın. Bir objede bulunan bir **‘Component’** ın değişkenlerine başka bir **‘Component’** ın ulaşabilmesi için Unity’de aşağıdaki kullanım mevcuttur
	```
	obje1.GetComponent <ulaşılacakcomponent> ().değişken
	```
	Oluşturduğumuz text **‘Obje’** lerinin text **‘Component’** ının text **‘Değişken’** ine ulaşmanız gerekmektedir. Bunun için gereken kod
	```
	obje1.GetComponent <Text> ().text= “” + hareket.x;
	```
	şeklinde olacaktır. ```“” +``` kullanımı **‘float’** türündeki ```hareket.x``` değişkenini **‘string’** formatına dönüştürmek için kullanılmaktadır. Gerekli kodları **‘Update’** içine yazarak sırasıyla ```hareket.x``` ve ```hareket.z``` ye eşitleyin. Play tuşuna basarak ok tuşlarını kullanın ve sonucu gözlemleyin.
  
  -	**‘Update’** içerisinde **‘GetComponent’** ile **‘RigidBody’** **‘Component’** ına erişin ve içerisinde bulunan ```AddForce()``` fonksiyonunu tanımlanmış **hareket** vektörü ile kullanarak küreyi hareket ettiren kodu yazın.
  -	**‘Update’** te bir **if** içerisine 
	```
	Input.GetKeyDown(KeyCode.Space)
	```
	yazarak **‘space’** tuşuna basıldığında çalışacak şekilde topu zıplatacak bir kod yazın. **‘Unity’** de **‘Floor’** objesinin **tag** ı olmak üzere **‘Tag’** bölmesine tıklayarak **“Yer”** adında yeni bir tag oluşturun. Yazılmış olan kodun altındaki bölümde görülebileceği üzere hareket fonksiyonu cismin dokunduğu cismin tag’i **“Yer”** ise **‘yerde’** değişkenini **‘true’** olarak değiştirmektedir. Siz de kodun yalnızca bu değişken **‘true’** iken çalışmasını sağlayın ve zıpladıktan sonra bu değişkeni **‘false’** yaparak havada iken tekrar zıplamayı engelleyin.

  
  -	Yazdığınız kodu GitHub’ınıza yükleyerek mail atın.
	- ***[Teaser](https://www.youtube.com/watch?v=ssIYDJRGDeU&list=PLSmWeUDtr9fDKXL0UDaCEFxkb9fbQEOZH&index=3)***