def sumar(num1, num2):
    total = num1 + num2
    return total

def restar (num1, num2):
    return num1 - num2

def mult (num1, num2):
    return num1 * num2

def main():
    num1 = 12
    num2 = 45

    print (sumar(num1,num2))

if __name__ == "__main__":
    main()


def main():
    num1 = 12
    num2 = 45
    
    print (restar(num1, num2))

if __name__ == "__main__":
    main()

def div (num1, num2):
    if (num1 ==0):
        return "no se puede dividir"
    else:
        return num1 / num2

def main():
    num1 = 12
    num2 = 45

    print(div(num1,num2))

if __name__ == "__main__":
    main()

def main():
    num1 = 12
    num2 = 45

    print (mult(num1, num2))

if __name__ == "__main__":
    main()
