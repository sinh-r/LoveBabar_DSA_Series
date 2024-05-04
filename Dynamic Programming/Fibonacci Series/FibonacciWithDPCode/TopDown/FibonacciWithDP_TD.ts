class FibWithDP_TD{
    _dp: number[];

    constructor(n: number) {
        this._dp = new Array(n+1);     
        this._dp[0] = 0;
        this._dp[1] = 1;   
    }

    getNthFibonacciNumber = (n: number): number => {
        if(n == 0 || n == 1){
            return n;
        }
        
        if(isNaN(this._dp[n])){
            this._dp[n] = this.getNthFibonacciNumber(n-1) + this.getNthFibonacciNumber(n-2);
        }
        return this._dp[n];
    }
}