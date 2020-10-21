# C# call libtest.so

## How to build and run
1. gcc -fPIC -shared test.cpp -o libtest.so
2. export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:$PWD 
3. dotnet run 

