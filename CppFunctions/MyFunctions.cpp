#define MyFunctions _declspec(dllexport)

extern "C" {
	MyFunctions int AddNumbers(int a, int b) {
		return a + b;
	}
	MyFunctions int SubtractNumbers(int a, int b) {
		return a - b;
	}
}