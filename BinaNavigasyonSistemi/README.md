Sistem, Dijkstra algoritmasını kullanarak çalışmaktadır. Kayseri Park AVM binasının birebir planı üzerinde çıkış kapıları üzerinde hesaplamalar yapılmaktadır. Her çıkış kapısı ya da merdiven ayrı ayrı açılıp kapatılabilmektedir. Daha sonra algoritma, seçilen bir noktadan (bölgeden) açık olan çıkışlardan en kısa olana bir rota çizecek, ortalama tahliye süresini ve toplam mesafeyi hesaplayacaktır.

Uygulamanın giriş ekranında fotoğrafta görüldüğü üzere kat seçim menüsü vardır.
![menu](https://github.com/user-attachments/assets/5f9faa1f-bc9e-44a0-9115-e59f36085af8)

Zemin ve Kat-1 e ait fotoğraftalarda görüldüğü üzere kırmızı daireler kapalı çıkışları yeşiller ise kullanıcı tarafından açılan çıkışları göstermektedir.Yeşil kesik çizgi ile hesaplanan rota görülmektedir.Eğer sadece merdiven çıkışı açıksa algoritma merdivenden devam edip alt katı otomatik açıyor ve oradaki aktif çıkışlardan en kısa tahliye rotasını çiziyor. Uygulama da eksiklikler bulunmakta geliştirmeye açıktır.

Zemin Kat:

![zemin](https://github.com/user-attachments/assets/8fa05acc-5781-4e40-8799-81feb84a2638)

Kat-1:

![kat1](https://github.com/user-attachments/assets/be996fea-adcf-4892-b449-073b007746f6)
