; Numeric-Process-Puzzle
(declare-fun number (Int) Int)
(declare-fun operation (Int) Int)
(declare-const N Int)

;This function states that there does not exist a number, which multiplied by two equals the parameter received
;thus the number in the parameter is an odd number
(define-fun IsOddNumber((sum Int)) Bool
  (not(exists ((y Int))
    (and
        (<= 0 y sum)
        (= (* y 2) sum)
    )
  ))
)

(assert (and
(= (number 0) 1)        ;the start number equals 1
(= (operation 0) 0)     ;the operation indicates wich one of the two step is chosen
(= (number N) 19)       ;the final number should be equal to 19

(forall ((t Int) (y Int))
    (implies 
	(<= 1 t N)  ;the steps are between 1 and the max steps (N)
    (or 
      (and 
        (= (number t) (* 2 (number (- t 1)) ) )            ;the number is multiplied by 2 
        (= (operation t) 1)                                ;the operation is set to 1 - the first operation is chosen
      )
      (and 
        (= (number t) (/ (- (number (- t 1)) 1) 3) )       ;the number is equal to the previous number minus one and subtracted by 3
        (IsOddNumber (number t))                           ;the number is odd number
        (= (operation t) 2)                                ;the operation is set to 2 - the second operation is chosen
      )
    )          
    )
)

;restrict the search to 20 steps
(<= 1 N 20)

))


(check-sat)
(get-value (
  N
 (number 0) (number 1) (number 2) (number 3) (number 4) (number 5)
 (number 6) (number 7) (number 8) (number 9) (number 10) (number 11)
 (number 12) (number 13) (number 14) (number 15) (number 16) (number 17)
 (number 18) (number 19) (number 20) 
 (operation 0) (operation 1) (operation 2) (operation 3) (operation 4) (operation 5)
 (operation 6) (operation 7) (operation 8) (operation 9) (operation 10) (operation 11)
 (operation 12) (operation 13) (operation 14) (operation 15) (operation 16) (operation 17)
 (operation 18) (operation 19) (operation 20) (operation 21) (operation 22)
))

