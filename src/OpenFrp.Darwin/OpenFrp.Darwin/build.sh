cd ~/projects/OpenFrp.Darwin
mkdir ./build
cp ./OpenFrp.Darwin/OpenFrp.Darwin/* ./build
cp ./OpenFrp.Unix.Common/* ./build
cd ./build
g++ ./main.cpp -o ./OpenFrp.Darwin.out
echo Over