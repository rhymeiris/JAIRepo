import java.util.Random;

//새로운 유전자
public class gene {
	private static String genome;//유전자 리스트
	private static int i=0;
	public static void gene(String str){
		genome=str;//유전자 이름
		i=0;
	}
	
	public static void newGene(String g){
		Random generator = new Random();
		//이부분을 데이터 베이스로 처리 해야함
		//유전자=테이블명 이미지정보=데이터 + 랜덤 행동양식을 추가해야함
		genome+=g+"|"+generator.nextInt(2)+generator.nextInt(2)+generator.nextInt(2)+generator.nextInt(2);
	}

}
