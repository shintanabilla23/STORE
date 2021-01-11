## STORE SHINTA
Aplikasi ini digunakan untuk membeli sebuah makanan dengan menerapkan MVC.

### SCOPE & FUNCTIONALITIES
- Membuat aplikasi pemesanan makanan.
- Membuat keranjang sebagai wadah makanan dan minuman yang dipesan.
- Bagian yang bertanggung jawab melakukan kalkulasi, diwadahi dalam kelas Payment

### TUJUAN
Memahami peran dan fungsi masing-masing bagian MVC. Serta untuk mengelompokkan fungsi-fungsi 
agar tidak berserakan,dan jelas menjadi satu kesatuan sesuai tipe datanya. 

### How does it works?
logika perhitungan untuk melakukan kalkulasi terdapat pad class `Payment.cs`
``` csharp
class Payment
    {
        OnPaymentChangedListener paymentListener;
        public Payment(OnPaymentChangedListener paymentListener)
        {

            this.paymentListener = paymentListener;
        }

        public void updateTotal(double subTotal, double promo)
        {

            double total = subTotal - promo;
            this.paymentListener.onPriceUpdated(subTotal, total, promo);

        }
    }
```
