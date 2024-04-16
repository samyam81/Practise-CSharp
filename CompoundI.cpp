#include <iostream>
#include <cmath>
#include <functional>

using namespace std;

double compoundInterestFunction(double p, double rate, int years) {
    return p * pow(1 + rate, years);
}

double calculateCompoundInterest(double principal, function<double(double)> interestFunction) {
    return interestFunction(principal);
}

int main() {
    double principal = 1000;
    double rate = 0.05;
    int years = 5;

    auto compoundInterest = [rate, years](double p) {
        return compoundInterestFunction(p, rate, years);
    };

    double result = calculateCompoundInterest(principal, compoundInterest);
    cout << "Compound interest after " << years << " years: " << result << endl;

    return 0;
}
