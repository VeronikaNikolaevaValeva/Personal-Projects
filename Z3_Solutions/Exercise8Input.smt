(declare-const a1 Int)
(declare-const b1 Int)
(declare-const c1 Int)
(declare-const d1 Int)
(declare-const e1 Int)
(declare-const f1 Int)

(declare-const a2 Int)
(declare-const b2 Int)
(declare-const c2 Int)
(declare-const d2 Int)
(declare-const e2 Int)
(declare-const f2 Int)

(declare-const a3 Int)
(declare-const b3 Int)
(declare-const c3 Int)
(declare-const d3 Int)
(declare-const e3 Int)
(declare-const f3 Int)

(assert (and
	  (forall ((a Int) (b Int) (c Int) (d Int) (e Int) (f Int) )
      (and
        (exists ((a Int) (b Int) (c Int) (d Int) (e Int) (f Int))  
			    (and 
              (<= 1 a 9) (<= 1 b 9) (<= 1 c 9) (<= 1 d 9) (<= 1 e 9) (<= 1 f 9)
              (= a1 a) (= b1 b) (= c1 c) (= d1 d) (= e1 e) (= f1 f)
          ) 
        )
        (exists ((a Int) (b Int) (c Int) (d Int) (e Int) (f Int))  
			    (and 
              (<= 1 a 9) (<= 1 b 9) (<= 1 c 9) (<= 1 d 9) (<= 1 e 9) (<= 1 f 9)
              (= a2 a) (= b2 b) (= c2 c) (= d2 d) (= e2 e) (= f2 f)
          ) 
        )
        (exists ((a Int) (b Int) (c Int) (d Int) (e Int) (f Int))  
			    (and 
              (<= 1 a 9) (<= 1 b 9) (<= 1 c 9) (<= 1 d 9) (<= 1 e 9) (<= 1 f 9)
              (= a3 a) (= b3 b) (= c3 c) (= d3 d) (= e3 e) (= f3 f)
          ) 
        )
      )

		)
	)
)

(define-fun DiceOneThrowsBiggerThanDiceTwo ((aA Int) (bA Int) (cA Int) (dA Int) (eA Int) (fA Int) (aB Int) (bB Int) (cB Int) (dB Int) (eB Int) (fB Int)) Bool  
    (>= (+
          (ite (> aA aB) 1 0) (ite (> aA bB) 1 0) (ite (> aA cB) 1 0) 
          (ite (> aA dB) 1 0) (ite (> aA eB) 1 0) (ite (> aA fB) 1 0)
          (ite (> bA aB) 1 0) (ite (> bA bB) 1 0) (ite (> bA cB) 1 0) 
          (ite (> bA dB) 1 0) (ite (> bA eB) 1 0) (ite (> bA fB) 1 0)
          (ite (> cA aB) 1 0) (ite (> cA bB) 1 0) (ite (> cA cB) 1 0) 
          (ite (> cA dB) 1 0) (ite (> cA eB) 1 0) (ite (> cA fB) 1 0)
          (ite (> dA aB) 1 0) (ite (> dA bB) 1 0) (ite (> dA cB) 1 0) 
          (ite (> dA dB) 1 0) (ite (> dA eB) 1 0) (ite (> dA fB) 1 0)
          (ite (> eA aB) 1 0) (ite (> eA bB) 1 0) (ite (> eA cB) 1 0) 
          (ite (> eA dB) 1 0) (ite (> eA eB) 1 0) (ite (> eA fB) 1 0)
          (ite (> fA aB) 1 0) (ite (> fA bB) 1 0) (ite (> fA cB) 1 0) 
          (ite (> fA dB) 1 0) (ite (> fA eB) 1 0) (ite (> fA fB) 1 0)
    )20)
)

(assert(and
  (=(+
    (ite (DiceOneThrowsBiggerThanDiceTwo a1 b1 c1 d1 e1 f1 a2 b2 c2 d2 e2 f2) 1 0)
    (ite (DiceOneThrowsBiggerThanDiceTwo a2 b2 c2 d2 e2 f2 a3 b3 c3 d3 e3 f3) 1 0)
    (ite (DiceOneThrowsBiggerThanDiceTwo a3 b3 c3 d3 e3 f3 a1 b1 c1 d1 e1 f1) 1 0)
  )3)
))

(check-sat)
(get-value (
  a1 b1 c1 d1 e1 f1
  a2 b2 c2 d2 e2 f2
  a3 b3 c3 d3 e3 f3
))
