angka = float(input('Selamat datang di SPBU Kelompok 40, Apakah anda ingin berbelanja? 1 Jika Ya, 2 Jika Tidak = '))
if angka == 1:
    menu = [["Premium 1 Liter", 7300], ["Premium 2 Liter", 14600], ["Premium 3 Liter", 21900], ["Pertamax 1 Liter", 8600], ["Pertamax 2 Liter", 17200], ["Pertamax 3 Liter", 25800], ["Pertalite 1 Liter", 8400], ["Pertalite 2 Liter", 16800], ["Pertalite 3 Liter", 25200], ["Solar 1 Liter", 6900], ["Solar 2 Liter", 13800], ["Solar 3 Liter", 20700]] 
    def jenis_bbm():
        print("#-----------Selamat Datang------------#")
        print("#-------------------------------------#") 
        print("# No    |    Jenis BBM    |    Harga  #") 
        print("#-------------------------------------#") 
        i = 1 
        for item in menu: 
            print("# " + str(i) + " | " + item[0] + " | " + str(item[1]) + " #") 
            i += 1 
        print("#-------------------------------------#") 
        print("# 0 |          Checkout               #") 
        print("#-------------------------------------#") 
        return 


    jenis_bbm() 
    jawaban = "" 
    catatan_pilihan = [] 
    while jawaban != "0": 
        jawaban = input("Pilih jenis BBM ") 
        jenis_bbm() 
        if jawaban != "0": 
            catatan_pilihan.append(int(jawaban)-1) 

    no = 1 
    print("Pesanan anda : ") 
    total = 0 
    for pilihan in catatan_pilihan: 
        print("Pembelian BBM ke " + str(no) + " = " + menu[pilihan][0] + " Harga + " + str(menu[pilihan][1])) 
        no += 1 
        total = total + menu[pilihan][1] 

    print("Total pembayaran " + str(total))
    print("Terimakasih sudah berbelanja di SPBU Kelompok 40")

elif angka == 2:
    print("Terimakasih sudah mengunjungi SPBU Kelompok 40")
