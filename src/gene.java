import java.util.Random;

//���ο� ������
public class gene {
	private static String genome;//������ ����Ʈ
	private static int i=0;
	public static void gene(String str){
		genome=str;//������ �̸�
		i=0;
	}
	
	public static void newGene(String g){
		Random generator = new Random();
		//�̺κ��� ������ ���̽��� ó�� �ؾ���
		//������=���̺�� �̹�������=������ + ���� �ൿ����� �߰��ؾ���
		genome+=g+"|"+generator.nextInt(2)+generator.nextInt(2)+generator.nextInt(2)+generator.nextInt(2);
	}

}
