numb = input().split()
numa = int(numb[0])
numberb = int(numb[1])
numc = int(numb[2])
numd = int(numb[3])
maxnum = max(numa, numberb, numc, numd)
minnum = min(numa, numberb, numc, numd)
marichka = maxnum + minnum
zenuk = numa + numberb + numc + numd - marichka
if marichka > zenuk:
    print("Marichka")
elif marichka < zenuk:
    print("Zenuk")
else:
    print("Love always wins")