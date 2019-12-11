===================================================================================
KOMMUNE:

Hent kommune Helsingør
http://localhost:54373/odata/Kommune?$filter=Kode eq '0217'
http://localhost:54373/odata/Kommune('0217')


===================================================================================
ADRESSE

Hent adresse med id D540A0BD-50CC-4408-992F-0000161122ED
http://localhost:54373/odata/Adresse?$filter=Id eq D540A0BD-50CC-4408-992F-0000161122ED
http://localhost:54373/odata/Adresse(D540A0BD-50CC-4408-992F-0000161122ED


===================================================================================
DAR AFSTEMNINGSOMRÅDE:

Hent alle afstemningsområder:
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel

Hent afstemningsområde med id CB07758C-1804-46F2-8271-003BD873165E
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel?$filter=Id eq CB07758C-1804-46F2-8271-003BD873165E
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel(CB07758C-1804-46F2-8271-003BD873165E)

Hent alle afstemningsområder med status 4:
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel?$filter=Status eq 4

Hent alle afstemningsområder med status > 3:
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel?$filter=Status gt 3

Hent alle afstemningsområder med status < 3: (der er vist ikke nogen pt...)
http://localhost:54373/odata/Dar_darafstemningsområde_aktuel?$filter=Status lt 3
