(declare-fun B (Int Int) Bool)

(define-fun OneQueensOnEachCol ((col Int)) Bool
	(or (B 1 col) (B 2 col) (B 3 col) 
	(B 4 col) (B 5 col) (B 6 col) (B 7 col) (B 8 col)) 
)

(define-fun Exactly8Col () Bool
	(and (OneQueensOnEachCol 1)
		 (OneQueensOnEachCol 2)
		 (OneQueensOnEachCol 3)
		 (OneQueensOnEachCol 4)
		 (OneQueensOnEachCol 5)
		 (OneQueensOnEachCol 6)
		 (OneQueensOnEachCol 7)
		 (OneQueensOnEachCol 8)
	)
)

(define-fun OneQueensOnEachRow ((row Int)) Bool
			(or (B row 1) (B row 2) (B row 3) 
			(B row 4) (B row 5) (B row 6) (B row 7) (B row 8)) 
	  )

(define-fun Exactly8Rows () Bool
	(and (OneQueensOnEachRow 1)
		 (OneQueensOnEachRow 2)
		 (OneQueensOnEachRow 3)
		 (OneQueensOnEachRow 4)
		 (OneQueensOnEachRow 5)
		 (OneQueensOnEachRow 6)
		 (OneQueensOnEachRow 7)
		 (OneQueensOnEachRow 8)
	)
)

(define-fun NotTwoQuensOnSameRow ((row Int)) Bool
	(= (+ 	(ite (B row 1) 1 0) (ite (B row 2) 1 0) (ite (B row 3) 1 0)
			(ite (B row 4) 1 0) (ite (B row 5) 1 0) (ite (B row 6) 1 0) 
			(ite (B row 7) 1 0) (ite (B row 8) 1 0))
		1) 
	  )

		(define-fun Rows () Bool
		(and (NotTwoQuensOnSameRow 1 )
			 (NotTwoQuensOnSameRow 2 )
			 (NotTwoQuensOnSameRow 3 )
			 (NotTwoQuensOnSameRow 4 )
			 (NotTwoQuensOnSameRow 5 )
			 (NotTwoQuensOnSameRow 6 )
			 (NotTwoQuensOnSameRow 7 )
			 (NotTwoQuensOnSameRow 8 )
		)
	)

	(define-fun NotTwoQuensOnSameCol ((col Int)) Bool
	(= (+ 	(ite (B 1 col) 1 0) (ite (B 2 col) 1 0) (ite (B 3 col) 1 0)
		(ite (B 4 col) 1 0) (ite (B 5 col) 1 0) (ite (B 6 col) 1 0) 
		(ite (B 7 col) 1 0) (ite (B 8 col) 1 0))
		1)
  )

	(define-fun Cols () Bool
		(and (NotTwoQuensOnSameCol 1 )
			 (NotTwoQuensOnSameCol 2 )
			 (NotTwoQuensOnSameCol 3 )
			 (NotTwoQuensOnSameCol 4 )
			 (NotTwoQuensOnSameCol 5 )
			 (NotTwoQuensOnSameCol 6 )
			 (NotTwoQuensOnSameCol 7 )
			 (NotTwoQuensOnSameCol 8 )
		)
	)

(define-fun NotTwoQuensOnSameDiagonal8 ((B1 Bool) (B2 Bool) (B3 Bool) (B4 Bool)
										(B5 Bool) (B6 Bool) (B7 Bool) (B8 Bool)) Bool
	(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0)
			(ite B4 1 0) (ite B5 1 0) (ite B6 1 0) 
			(ite B7 1 0) (ite B8 1 0))
	1))
	
(define-fun NotTwoQuensOnSameDiagonal7 ((B1 Bool) (B2 Bool) (B3 Bool) (B4 Bool)
(B5 Bool) (B6 Bool) (B7 Bool)) Bool
		(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0)
				(ite B4 1 0) (ite B5 1 0) (ite B6 1 0) 
				(ite B7 1 0))
		1))

(define-fun NotTwoQuensOnSameDiagonal6 ((B1 Bool) (B2 Bool) (B3 Bool) (B4 Bool)
(B5 Bool) (B6 Bool)) Bool
		(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0)
				(ite B4 1 0) (ite B5 1 0) (ite B6 1 0))
		1))	

(define-fun NotTwoQuensOnSameDiagonal5 ((B1 Bool) (B2 Bool) (B3 Bool) (B4 Bool)
(B5 Bool)) Bool
			(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0)
					(ite B4 1 0) (ite B5 1 0))
			1))

(define-fun NotTwoQuensOnSameDiagonal4 ((B1 Bool) (B2 Bool) (B3 Bool) (B4 Bool)) Bool
		(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0) (ite B4 1 0)) 1))

(define-fun NotTwoQuensOnSameDiagonal3 ((B1 Bool) (B2 Bool) (B3 Bool)) Bool
		(<= (+ 	(ite B1 1 0) (ite B2 1 0) (ite B3 1 0)) 1))


(define-fun NotTwoQuensOnSameDiagonal2 ((B1 Bool) (B2 Bool)) Bool
		(<= (+ 	(ite B1 1 0) (ite B2 1 0)) 1))

(define-fun UniqueDiagonals () Bool
		(and 	(NotTwoQuensOnSameDiagonal8 (B 1 1) (B 2 2) (B 3 3) (B 4 4) 
											(B 5 5) (B 6 6) (B 7 7) (B 8 8)) 
				(NotTwoQuensOnSameDiagonal8 (B 1 8) (B 2 7) (B 3 6) (B 4 5) 
											(B 5 4) (B 6 3) (B 7 2) (B 8 1)) 

				(NotTwoQuensOnSameDiagonal7 (B 1 7) (B 2 6) (B 3 5) (B 4 4) 
											(B 5 3) (B 6 2) (B 7 1) ) 
				(NotTwoQuensOnSameDiagonal7 (B 1 2) (B 2 3) (B 3 4) (B 4 5) 
											(B 5 6) (B 6 7) (B 7 8) ) 
				(NotTwoQuensOnSameDiagonal7 (B 2 8) (B 3 7) (B 4 6) (B 5 5) 
											(B 6 4) (B 7 3) (B 8 2) ) 
				(NotTwoQuensOnSameDiagonal7 (B 2 1) (B 3 2) (B 4 3) (B 5 4)
											(B 6 5) (B 7 6) (B 8 7) )

				(NotTwoQuensOnSameDiagonal6 (B 1 6) (B 2 5) (B 3 4) (B 4 3) 
											(B 5 2) (B 6 1) ) 
				(NotTwoQuensOnSameDiagonal6 (B 3 8) (B 4 7) (B 5 6) (B 6 5) 
											(B 7 4) (B 8 3) ) 
				(NotTwoQuensOnSameDiagonal6 (B 1 3) (B 2 4) (B 3 5) (B 4 6) 
											(B 5 7) (B 6 8) ) 
				(NotTwoQuensOnSameDiagonal6 (B 3 1) (B 4 2) (B 5 3) (B 6 4) 
											(B 7 5) (B 8 6) )	
											
				(NotTwoQuensOnSameDiagonal5 (B 4 1) (B 5 2) (B 6 3) (B 7 4) 
											(B 8 5) ) 
				(NotTwoQuensOnSameDiagonal5 (B 1 5) (B 2 4) (B 3 3) (B 4 2) 
											(B 5 1) ) 
				(NotTwoQuensOnSameDiagonal5 (B 4 8) (B 5 7) (B 6 6) (B 7 5) 
											(B 8 4) ) 
				(NotTwoQuensOnSameDiagonal5 (B 1 4) (B 2 5) (B 3 6) (B 4 7) 
											(B 5 8) )
											
				(NotTwoQuensOnSameDiagonal4 (B 5 8) (B 6 7) (B 7 6) (B 8 5) ) 
				(NotTwoQuensOnSameDiagonal4 (B 1 4) (B 2 3) (B 3 2) (B 4 1) ) 
				(NotTwoQuensOnSameDiagonal4 (B 1 5) (B 2 6) (B 3 7) (B 4 8) ) 
				(NotTwoQuensOnSameDiagonal4 (B 5 1) (B 6 2) (B 7 3) (B 8 4) )
				
				(NotTwoQuensOnSameDiagonal3 (B 1 6) (B 2 7) (B 3 8) )
				(NotTwoQuensOnSameDiagonal3 (B 6 1) (B 7 2) (B 8 3) )
				(NotTwoQuensOnSameDiagonal3 (B 1 3) (B 2 2) (B 3 1) )
				(NotTwoQuensOnSameDiagonal3 (B 6 8) (B 7 7) (B 8 6) )

				(NotTwoQuensOnSameDiagonal2 (B 7 8) (B 8 7) )
				(NotTwoQuensOnSameDiagonal2 (B 1 2) (B 2 1) )
				(NotTwoQuensOnSameDiagonal2 (B 1 7) (B 2 8) )
				(NotTwoQuensOnSameDiagonal2 (B 7 1) (B 8 2) )
			)
	)

(assert (and
		Exactly8Col Exactly8Rows Cols Rows UniqueDiagonals
	)
)

		
(check-sat)
(get-model)
(get-value (
	(B 1 1) (B 1 2) (B 1 3) (B 1 4) (B 1 5) (B 1 6) (B 1 7) (B 1 8) 
	(B 2 1) (B 2 2) (B 2 3) (B 2 4) (B 2 5) (B 2 6) (B 2 7) (B 2 8)
	(B 3 1) (B 3 2) (B 3 3) (B 3 4) (B 3 5) (B 3 6) (B 3 7) (B 3 8)
	(B 4 1) (B 4 2) (B 4 3) (B 4 4) (B 4 5) (B 4 6) (B 4 7) (B 4 8)
	(B 5 1) (B 5 2) (B 5 3) (B 5 4) (B 5 5) (B 5 6) (B 5 7) (B 5 8) 
	(B 6 1) (B 6 2) (B 6 3) (B 6 4) (B 6 5) (B 6 6) (B 6 7) (B 6 8)
	(B 7 1) (B 7 2) (B 7 3) (B 7 4) (B 7 5) (B 7 6) (B 7 7) (B 7 8)
	(B 8 1) (B 8 2) (B 8 3) (B 8 4) (B 8 5) (B 8 6) (B 8 7) (B 8 8)

))

