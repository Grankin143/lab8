import java.util.Scanner;

public class lab5 {
    public static void main(String[] args) {
        String encoding = System.getProperty("console.encoding", "cp866"), name1, num1, nameLek1, mass1, f;
        Scanner in = new Scanner(System.in, encoding);
        Apteka[] apteka = new Apteka[10];
        Lek[] lek = new Lek[10];
        Number p = new Number();
        int numOfMeds1, amount1, i, k, n;
        double price1;
        System.out.println("Ввести данные через read или init(1 - read, 2 - init)");
        f = in.nextLine();
        if(f.equals("1")){
            apteka[0] = new Apteka();
            apteka[0].read();
        }
        else{
            System.out.println("Введите название аптеки");
            name1 = in.nextLine();
            System.out.println("Введите номер аптеки");
            num1 = in.nextLine();
            System.out.println("Добавить лекарство (1 - Да, 0 - Нет)");
            f = in.nextLine();
            i = 0;
            while(f.equals("1")){
                System.out.println("Введите название лекарства");
                nameLek1 = in.nextLine();
                System.out.println("Введите код лекарства");
                mass1 = in.nextLine();
                System.out.println("Введите цену лекарства");
                price1 = in.nextDouble();
                System.out.println("Введите колличество лекарства");
                amount1 = in.nextInt();
                in.nextLine();
                lek[i] = new Lek();
                lek[i].init(mass1, nameLek1, price1, amount1);
                i++;
                System.out.println("Добавить лекарство (1 - Да, 0 - Нет)");
                f = in.nextLine();
            }
            numOfMeds1 = i;
            apteka[0] = new Apteka();
            apteka[0].init(name1, num1, numOfMeds1, lek);
        }
        f = "0";
        i = 0;
        k = 1;
        while(f.equals("9") == false){
            System.out.println("Введите номер следующего действия");
            System.out.println("1 - Показать информацию о аптеки");
            System.out.println("2 - Добавить новое лекарство");
            System.out.println("3 - Изменить цену лекарства");
            System.out.println("4 - Добавить аптеку");
            System.out.println("5 - Показать все аптеки");
            System.out.println("6 - Сменить аптеку");
            System.out.println("7 - Показать колличество лекарств");
            System.out.println("8 - Изменить колличество мест для лекарств в аптеки");
            System.out.println("9 - Выход");
            f = in.nextLine();
            if(f.equals("1")){
                apteka[i].display();
            }
            else if(f.equals("2")){
                apteka[i].add();
            }
            else if(f.equals("3")){
                System.out.println("Введите код лекарства");
                mass1 = in.nextLine();
                System.out.println("Введите новую цену");
                price1 = in.nextDouble();
                in.nextLine();
                apteka[i].priceChange(mass1, price1);
            }
            else if(f.equals("4")){
                apteka[k] = new Apteka();
                apteka[k].read();
                i=k;
                k++;
            }
            else if(f.equals("5")){
                for(n = 0; n < k; n++){
                    apteka[n].displayName();
                }
            }
            else if(f.equals("6")){
                System.out.println("Введите название аптеки");
                name1 = in.nextLine();
                for(n = 0; n < k; n++){
                    if(apteka[n].aptekacmp(name1)){
                        i = n;
                        n = k;
                    }
                }
            }
            else if(f.equals("7")){
                apteka[i].getNumber(p);
                System.out.println(p.number);
            }
            else if(f.equals("8")){
                System.out.println("Введите колличество");
                numOfMeds1 = in.nextInt();
                Apteka.maxNumOfMedsChange(numOfMeds1);
            }
        }    
    }
}