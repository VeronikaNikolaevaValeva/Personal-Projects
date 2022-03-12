(declare-fun B (Int Int) Bool)

(define-fun SevenMedicinesInCol ((col Int)) Bool
	(or (B 1 col) (B 2 col) (B 3 col) 
	(B 4 col) (B 5 col) (B 6 col) (B 7 col)) 
)

(define-fun Exactly7MedicineCol () Bool
	(and (SevenMedicinesInCol 1)
		 (SevenMedicinesInCol 2)
		 (SevenMedicinesInCol 3)
		 (SevenMedicinesInCol 4)
		 (SevenMedicinesInCol 5)
		 (SevenMedicinesInCol 6)
		 (SevenMedicinesInCol 7)
	)
)

(define-fun SevenTestRoundInRows ((row Int)) Bool
			(or (B row 1) (B row 2) (B row 3) 
			(B row 4) (B row 5) (B row 6) (B row 7)) 
	  )

(define-fun Exactly7TestRoundsRows () Bool
	(and (SevenTestRoundInRows 1)
		 (SevenTestRoundInRows 2)
		 (SevenTestRoundInRows 3)
		 (SevenTestRoundInRows 4)
		 (SevenTestRoundInRows 5)
		 (SevenTestRoundInRows 6)
		 (SevenTestRoundInRows 7)
	)
)

(define-fun ThreeMedsOnRow ((row Int)) Bool
	(= (+ 	(ite (B row 1) 1 0) (ite (B row 2) 1 0) (ite (B row 3) 1 0)
			(ite (B row 4) 1 0) (ite (B row 5) 1 0) (ite (B row 6) 1 0) 
			(ite (B row 7) 1 0))
		3) 
	  )
	  
(define-fun Rows () Bool
	(and (ThreeMedsOnRow 1)
		 (ThreeMedsOnRow 2)
		 (ThreeMedsOnRow 3)
		 (ThreeMedsOnRow 4)
		 (ThreeMedsOnRow 5)
		 (ThreeMedsOnRow 6)
		 (ThreeMedsOnRow 7)
	)
)

(define-fun ThreeTestRoundsOnCol ((col Int)) Bool
		(= (+ 	(ite (B 1 col) 1 0) (ite (B 2 col) 1 0) (ite (B 3 col) 1 0)
			(ite (B 4 col) 1 0) (ite (B 5 col) 1 0) (ite (B 6 col) 1 0) 
			(ite (B 7 col) 1 0))
		3)
	  )

(define-fun Cols () Bool
	(and (ThreeTestRoundsOnCol 1)
		 (ThreeTestRoundsOnCol 2)
		 (ThreeTestRoundsOnCol 3)
		 (ThreeTestRoundsOnCol 4)
		 (ThreeTestRoundsOnCol 5)
		 (ThreeTestRoundsOnCol 6)
		 (ThreeTestRoundsOnCol 7)
	)
)

(assert (and
Exactly7MedicineCol Exactly7TestRoundsRows Rows Cols
		)
)

(check-sat)
(get-model)
(get-value (
	(B 1 1) (B 1 2) (B 1 3) (B 1 4) (B 1 5) (B 1 6) (B 1 7)
	(B 2 1) (B 2 2) (B 2 3) (B 2 4) (B 2 5) (B 2 6) (B 2 7)
	(B 3 1) (B 3 2) (B 3 3) (B 3 4) (B 3 5) (B 3 6) (B 3 7)
	(B 4 1) (B 4 2) (B 4 3) (B 4 4) (B 4 5) (B 4 6) (B 4 7)
	(B 5 1) (B 5 2) (B 5 3) (B 5 4) (B 5 5) (B 5 6) (B 5 7) 
	(B 6 1) (B 6 2) (B 6 3) (B 6 4) (B 6 5) (B 6 6) (B 6 7)
	(B 7 1) (B 7 2) (B 7 3) (B 7 4) (B 7 5) (B 7 6) (B 7 7) 

))
