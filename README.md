1.What
==
전체 프로젝트 PPT
--
[PCB Visual Inspection_final.pptx](https://github.com/blackzero23/PCB-VI-MES-/files/3586225/PCB.Visual.Inspection_final.pptx)

1.1 프로젝트 이름 과 구성
--
 프로젝트 : PCB - VI - MES  (화면 비전을 통한 PCB 오류 검출 자동화 시스템.)

 ![image](https://user-images.githubusercontent.com/49605999/64469829-f26a2e80-d173-11e9-9f5a-0cbdfa619d4d.png)
 
 C#의 Winform을 활용한 Mes Application 제작 
----
- 아두이노 를 이용한 로봇팔 제어.(GitHub URL :)  
- 라즈베리파이를 이용한 화면비젼 (GitHub URL : )

1.2 기능 설명
--
  기준정보관리 : 프로그램에 필요한 메타 데이터 정보 관리
   - 사원정보, 품목정보, 바코드, 불량정보, 검사기준정보, 설비정보
   
 생산관리 : 생산 에 관련한 정보관리 및 조회
   - 생산이력,작업지시관리,작업일보,작업자,불량관리
   
 자재관리
   - 자재이력 : 현재 자재 위치 추적관리
   
 설비 관리
   - 설비가동/비가동 : 현재 설비가 가동된 시간 및 비가동된 시간 그리드 및 그래프 표현
   - 설비이력 : 설비 이슈 관리
   
 품질 관리
   - 수입검사,출하전 검사
   
 모니터링 
  - 설비현황 모니터링
 
1.3 전체 프로젝트 흐름
--
흐름 : 작업지시 작성 -> 작업자 -> 작업시작 -> 작업일보 자동 작성 -> 목표수량 생산 완료 및 작업종료 버튼 을 누를시
      ->작업일보, 생산이력, 설비가동 비가동 자동 작성.

설비 영상 : https://www.youtube.com/watch?v=_Zxt3b80D2w

MES 프로그램 설명 : 영상 :
 
2.HOW
==

2.1 DB 설계
--
[PCB_VI.zip](https://github.com/blackzero23/PCB-VI-MES-/files/3586229/PCB_VI.zip)


2.2 전체 솔루션 구성
--

전체적인 솔루션 구성은 메인 프로그램, 클래스 라이브러리, 유닛테스트용(콘솔프로젝트)로 구성하였습니다.

![Project](https://user-images.githubusercontent.com/49605999/63368503-06aedd00-c3b9-11e9-97be-03f6ffd12b98.png)


2.3 구현 기술
--
1. EF : EF(EntityFrameWork 6.x)를 통하여 DB 테이블을 매핑 하였습니다.
2. LINQ : 매핑되어 나온 클래스를 LINQ 를 통해서 직접 쿼리문을 작성하는것이 아닌 저장되어있는 프로시저를 사용하거나
          LINQ C#으로 쿼리문 작성 이 가능합니다.
3. CCTV : 설비의 상황을 보기위한 CCTV 구현 AForge.Net 누겟을 이용 하였고, raspberryPi를 이용 하여 FFmpeg를 통해 Webcam이용하여 영상을
          찍고 Motion을 통해 스트리밍서버를 구축 하였습니다.

4. TIP/IP : 작업 시작, 작업 종료 , 목표생산량을 완수하였을때 raspberryPi 와 C# 응용 프로그램 단 의 통신을
           구현하기위해 TCP/IP 통신을 이용하였습니다.

5. UI : 오픈 소스 인 Krypton, Material Skin을 이용 하였습니다. 
 
2.4 개발 환경
--
운영 체제 : Windows 7 Professional K

컴파일 버전(언어) : Roslyn

CPU : IntelⓇ Core™ i7-4790 CPU @ 3.60GHz

메모리 : 8GB

IDE : Microsoft Visual Studio Community 2019 버전 16.0.3

Microsoft .NET Framework 4.7.2

DB : MSSQL

H/W : RasberryPi 4


--

3. 추후 보안 사항
==========================

 -  업무 분석후 리빌딩.

 - 현재 Winform 인것을 WPF로 만들거나  모바일 연동 ,ASP.NET으로 WEP 

