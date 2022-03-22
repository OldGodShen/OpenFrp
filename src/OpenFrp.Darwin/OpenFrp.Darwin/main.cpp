#include "work.cpp"
#include "libDarwin.cpp"

#define Arch "amd64"
#define Darwin "Darwin"

OpenFrp openfrp(get_cur_executable_path_(), Arch, Darwin);

int main() {
	return openfrp.main();
}