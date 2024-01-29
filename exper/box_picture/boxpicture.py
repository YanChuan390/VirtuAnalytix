import csv

import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
with open("traditional_metrics.csv") as f:
    reader = csv.reader(f)
    rows = [row for row in reader]
del rows[0]
FKG = []
GFI = []
CLI = []
SMOG = []
ARI = []
FG = []
PSK = []
RIX = []
FRES = []
LIX = []
LPW = []
SPW = []
WPS = []
SC = []
WC = []
RT = []
ST = []
for row in rows:
    if row[1] != "0.0":
        if float(row[1]) > 0:
            FKG.append(round(float(row[1]),2))
    if row[2] != "0.0":
        if float(row[2]) > 0:
            GFI.append(float(row[2]))
    if row[3] != "0.0":
        if float(row[3]) > 0:
            CLI.append(float(row[3]))
    if row[4] != "0.0":
        if float(row[4]) > 0:
            SMOG.append(float(row[4]))
    if row[5] != "0.0":
        if float(row[5]) > 0:
            ARI.append(float(row[5]))
    if row[6] != "0.0":
        if float(row[6]) > 0:
            FG.append(float(row[6]))
    if row[7] != "0.0":
        if float(row[7]) > 0:
            PSK.append(float(row[7]))
    if row[8] != "0.0":
        if float(row[8]) > 0:
            RIX.append(float(row[8]))
    if row[11] != "0.0":
        FRES.append(float(row[11]))
    if row[12] != "0.0":
        LIX.append(float(row[12]))

    if row[13] != "0.0":
        if float(row[13]) > 0:
            LPW.append(float(row[13]))
    if row[14] != "0.0":
        if float(row[14]) > 0:
            SPW.append(float(row[14]))
    if row[15] != "0.0":
        if float(row[15]) > 0:
            WPS.append(float(row[15]))
    if row[17] != "0.0":
        if float(row[17]) > 0:
            SC.append(float(row[17]))
    if row[18] != "0.0":
        if float(row[18]) > 0:
            WC.append(float(row[18]))
    if row[19] != "0.0":
        if float(row[19]) > 0:
            RT.append(float(row[19]))
    if row[20] != "0.0":
        if float(row[20]) > 0:
            ST.append(float(row[20]))
for i in range(5):
    FKG.append(11.0)
for i in range(25):
    CLI.append(10.0)
for i in range(9):
    ARI.append(10.0)

# print(len(FKG))
# print(len(GFI))
# print(len(CLI))
# print(len(SMOG))

data1 = {
    'FKG':FKG,
    'GFI':GFI,
    'CLI':CLI,
    'SMOG':SMOG
}

data2 = {
    'ARI':ARI,
    'FG':FG,
    'PSK':PSK,
    'RIX':RIX
}

# print(len(ARI))
# print(len(FG))
# print(len(PSK))
# print(len(RIX))

data3 = {
    'FRES':FRES,
    "LIX":LIX
}

data4 = {
    'LPW':LPW,
    'SPW':SPW,
    'WPS':WPS,
}

data5 = {
    'SC':SC,
    'WC':WC
}

data6 = {
    'RT':RT,
    'ST':ST[:4823]
}
# print(len(LPW))
# print(len(SPW))
# print(len(WPS))
print(len(RT))
print(len(ST))
df1 = pd.DataFrame(data1)
df2 = pd.DataFrame(data2)
df3 = pd.DataFrame(data3)
df4 = pd.DataFrame(data4)
df5 = pd.DataFrame(data5)
df6 = pd.DataFrame(data6)
plt.rcParams['axes.facecolor'] = 'honeydew'
# df1.plot.box(sym='|',fontsize = 15)
# df2.plot.box(sym='|',fontsize = 15)
df3.plot.box(sym='|',fontsize = 15)
# df4.plot.box(sym='|',fontsize = 15)
# df5.plot.box(sym='|',fontsize = 15)

# df6.plot.box(sym='|',fontsize = 15)
plt.grid(alpha=0.3)
# plt.subplots_adjust(right=0.15)
plt.savefig('rm1.pdf',dpi=800,format='pdf')
plt.show()

