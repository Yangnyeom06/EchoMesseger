# (C# 코딩) 에코메신저
## 개요
- C# 프로그래밍학습
- 1줄소개: 사용자 키보드 입력을 받아서 처리하는 프로그램
- 사용한플랫폼: -C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한컨트롤:-Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
 - Visual Studio의 Windows Forms를 이용하여 UI 디자인

## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷
<img width="802" height="488" alt="image" src="https://github.com/user-attachments/assets/8163c05f-05ec-4326-9b31-380064da9ae9" />

- 과제내용
 - Label(표시), TextBox(입력), Button(전송), ListBox(대화창)를 적절히 배치.
 - 전송 버튼 클릭 시 TextBox의 텍스트를 ListBox의 항목(Items)으로 추가.
 - 추가 직후 TextBox의 내용을 비워(Clear) 다음 입력을 준비.
- 구현 내용과 기능 설명
 - 입력 창에 메시지 입력하고 전송 버튼을 누르면 메시지가 리스트 박스에 표시.
 - 계속 반복하면 메시지가 리스트 박스에 한 줄씩 계속 추가.

## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
![녹음 2026-03-19 161540](https://github.com/user-attachments/assets/d98fda08-85d9-4f4c-a287-b084a7844f2b)

- 과제내용
 - 메시지 전송 후 입력창에 입력 포커스 놓기
 - 메시지 엔터키로 전송
 - 텍스트 박스에 빈 문자열이나 공백만 있을 경우 메시지 전송 막기
- 구현 내용과 기능 설명
 - button1을 클릭하고 나서도 textBox1에 내용을 바로 추가 가능하도록 설정
 - textBox1_KeyDown 이벤트를 설정하여  Enter가 들어왔을때에도 button1_Click과 같은 실행을 하도록 설정
 - 만약 textBox1이 빈 문자열만 있거나 공백만 있다면 전송이 안되도록 설정

## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷
![녹음 2026-03-19 163403](https://github.com/user-attachments/assets/fc43e37f-7648-49f7-80b5-9b329e83b429)

- 과제내용
 - 메시지 앞에 메시지 현재 시간 추가
 - ListBox에 쌓인 총 메시지 개수를 계산하여 Label에 업데이트
 - 사용자가 입력한 메시지의 앞뒤 불필요한 공백을 Trim() 함수로 제거하여 저장
 - 텍스트 박스에 빈 문자열이나 공백만 있을 경우 메시지 전송 막기
- 구현 내용과 기능 설명
 - DateTime을 사용하여 출력 시 앞에 시간이 표시되게 추가
 - 현재 메시지 개수를 출력해줄 label2 추가
 - label2에 listBox의 Item 개수를 가져와 입력과 동시에 업데이트
 - Trim 함수를 사용하여 textBox1의 앞뒤 불필요한 공백을 삭제

## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷
![녹음 2026-03-19 172134](https://github.com/user-attachments/assets/6d7d6183-08b2-439a-ac8e-feea14da2246)

- 과제내용
 - 선택한 메시지 삭제(선택 안하고 삭제시 발생하는 오류 예외 처리)
 - 대화 기록 삭제 버튼을 누르면 listBox1 내 모든 내용 제거
 - textBox1 의 글자 수 50자로 제한, 초과시 사용자에게 경고 메시지를 띄우거나 전송 차단
- 구현 내용과 기능 설명
 - listBox1에서 선택한 index를 알 수 있도록 listBox1_SelectedIndexChanged를 사용 -> selectedListIndex 라는 변수를 만들고 거기에 선택한 인덱스 저장 -> 삭제를 담당하는 button2_Click에서 selectedListIndex가 -1이 아닐 경우 삭제
 - 대화 기록 삭제를 담당하는 button3 생성 -> 클릭 시 listBox1 내의 모든 내용 삭제
 - 현재 텍스트 박스에 입력 중인 내용을 파악하기 위해 textBox1_TextChanged 사용
 - 길이가 50 이상일때 경고 메시지를 띄울 label3 생성
 - 변경 될때 textBox1.Text의 길이를 파악한 후 만약 길이가 50이 넘으면 경고 메시지를 label3에 출력 그리고 sendAble false로 입력 막기, 50이 넘지 않으면 삭제

