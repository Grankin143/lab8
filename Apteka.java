import java.util.Scanner;

public class Apteka {
    String name;
    String num;
    int numOfMeds;
    static int maxNumOfMeds = 10;
    Lek[] lek = new Lek[10];
    void read(){
        int l,i;
        String encoding = System.getProperty("console.encoding", "utf-8");
        Scanner in = new Scanner(System.in, "utf-8");
        System.out.println("������� �������� ������");
        name = in.nextLine();
        System.out.println("������� ����� ������");
        num = in.nextLine();
        System.out.println("�������� ��������� (1 - ��, 0 - ���)");
        l = in.nextInt();
        i = 0;
        while(l == 1 && i < maxNumOfMeds){
            lek[i] = new Lek();
            lek[i].read();
            i++;
            System.out.println("�������� ��������� (1 - ��, 0 - ���)");
            l = in.nextInt();
        }
        numOfMeds = i;
    }
    void init(String name1, String num1, int numOfMeds1, Lek lek1[]){
        if (numOfMeds1 <= maxNumOfMeds){
            name = name1;
            num = num1;
            numOfMeds = numOfMeds1;
            for(numOfMeds1 = 0; numOfMeds1 < numOfMeds; numOfMeds1++){
                lek[numOfMeds1] = lek1[numOfMeds1];
            }
        }
    }
    void display(){
        int i;
        System.out.println("�������� ������:" + name);
        System.out.println("����� ������:" + num);
        System.out.println("����������� ��������:" + numOfMeds);
        System.out.println("������������ ����������� ���� ��� ��������:" + maxNumOfMeds);
        for(i = 0;i < numOfMeds; i++){
            System.out.println("���������:" + (i+1));
            lek[i].display();
        }
    }
    void add(){
        if(numOfMeds < maxNumOfMeds){
            lek[numOfMeds] = new Lek();
            lek[numOfMeds].read();
            numOfMeds++;
        }
    }
    void priceChange(String mass, double price){
        int i = 0;
        while(i < numOfMeds){
            if(mass.equals(lek[i].getMass())){
                lek[i].setPrice(price);
                i = numOfMeds;
            }
            i++;
        }
    }
    void displayName(){
        System.out.println("������:" + name);
    }
    boolean aptekacmp(String name1){
       if(name.equals(name1)){
           return true;
       }
       else {
           return false;
       }
    }
    void getNumber(Number p){
        p.number = numOfMeds;
    }
    static void maxNumOfMedsChange(int newMax){
        maxNumOfMeds = newMax;
    }
}