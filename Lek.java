import java.util.Scanner;
import java.io.PrintStream;

public class Lek {
    String name;
    String mass;
    double price;
    int amount;
    void read() {
        System.getProperty("console.encoding", "utf-8");
        Scanner in = new Scanner(System.in, "utf-8");
        System.out.println("������� �������� ���������");
        name = in.nextLine();
        System.out.println("������� ��� ���������");
        mass = in.nextLine();
        System.out.println("������� ���� ���������");
        price = in.nextDouble();
        System.out.println("������� ����������� ���������");
        amount = in.nextInt();
    }
    void init(String mass1, String name1, double price1, int amount1){
        mass = mass1;
        name = name1;
        price = price1;
        amount = amount1;
    }
    void display(){
        System.out.println("�������� ���������:" + name);
        System.out.println("��� ���������:" + mass);
        System.out.println("���� ���������:" + price);
        System.out.println("�����������:" + amount);
    }
    void setPrice(double price1){
        price = price1;
    }
    void setAmount(int amount1){
        amount = amount + amount1;
    }
    String getMass(){
        return mass;
    }
    int getAmount(){
        return amount;
    }
}
