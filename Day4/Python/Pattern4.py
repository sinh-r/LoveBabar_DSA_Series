n = int(input())

i = 1
while i <= n:
    j = n
    while j > 0:
        print(j, end = ' ')
        j -= 1
    print('\n', end = '')
    i += 1