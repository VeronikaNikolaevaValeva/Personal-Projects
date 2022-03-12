(declare-fun B (Int Int) Int)

(define-fun MinAndMaxValueFor8LitterJug ((row Int)) Bool
	(and (<= 0 (B row 1) 8) 
		 (<= 0 (B row 2) 5) 
		 (<= 0 (B row 3) 3)
	)
)

(define-fun MinMaxOnRowFor8litterJug () Bool
	(and (MinAndMaxValueFor8LitterJug 1) 
		 (MinAndMaxValueFor8LitterJug 2) 
		 (MinAndMaxValueFor8LitterJug 3) 
		 (MinAndMaxValueFor8LitterJug 4) 
		 (MinAndMaxValueFor8LitterJug 5) 
		 (MinAndMaxValueFor8LitterJug 6) 
		 (MinAndMaxValueFor8LitterJug 7) 
		 (MinAndMaxValueFor8LitterJug 8)
	)
)

(assert (and
		(= (B 1 1) 8) 
		(= (B 1 2) (B 1 3) (B 8 3) 0)
		(= (B 8 1) (B 8 2) 4)
))

(define-fun FillEachRow ((row1 Int) (row2 Int)) Bool
	(= (+
		(ite (and (= (B row2 1) (- (B row1 1) (- 5 (B row1 2)) )) (= (B row2 2) 5) (= (B row2 3) (B row1 3))  ) 1 0)
		(ite (and (= (B row2 1) (- (B row1 1) (- 3 (B row1 3)) )) (= (B row2 3) 3) (= (B row2 2) (B row1 2)) ) 1 0)
		(ite (and (= (B row2 1) 0) (= (B row2 3) (+ (B row1 3) (B row1 1) )) (= (B row2 2) (B row1 2)) ) 1 0)
		(ite (and (= (B row2 1) 0) (= (B row2 2) (+ (B row1 2) (B row1 1) )) (= (B row2 3) (B row1 3)) ) 1 0)

		(ite (and (= (B row2 2) (- (B row1 2) (- 3 (B row1 3)) )) (= (B row2 3) 3) (= (B row2 1) (B row1 1)) ) 1 0)  
		(ite (and (= (B row2 2) (- (B row1 2) (- 8 (B row1 1)) )) (= (B row2 1) 8) (= (B row2 3) (B row1 3)) ) 1 0)
		(ite (and (= (B row2 2) 0) (= (B row2 1) (+ (B row1 1) (B row1 2)) ) (= (B row2 3) (B row1 3)) ) 1 0)
		(ite (and (= (B row2 2) 0) (= (B row2 3) (+ (B row1 3) (B row1 2)) ) (= (B row2 1) (B row1 1)) ) 1 0)

		(ite (and (= (B row2 3) (- (B row1 3) (- 8 (B row1 1)) )) (= (B row2 1) 8) (= (B row2 2) (B row1 2)) ) 1 0)
		(ite (and (= (B row2 3) (- (B row1 3) (- 5 (B row1 2)) )) (= (B row2 2) 5) (= (B row2 1) (B row1 1)) ) 1 0) 
		(ite (and (= (B row2 3) 0) (= (B row2 1) (+ (B row1 1) (B row1 3)) ) (= (B row2 2) (B row1 2)) ) 1 0) 
		(ite (and (= (B row2 3) 0) (= (B row2 2) (+ (B row1 2) (B row1 3)) ) (= (B row2 1) (B row1 1)) ) 1 0))
	1)
)

(define-fun FindSkyscraperValuesForAllRows () Bool
	(and 
		 (FillEachRow 1 2)
		 (FillEachRow 2 3)
		 (FillEachRow 3 4)
		 (FillEachRow 4 5)
		 (FillEachRow 5 6)
		 (FillEachRow 6 7)
		 (FillEachRow 7 8)
	)
)

(assert (and
		  MinMaxOnRowFor8litterJug
			FindSkyscraperValuesForAllRows 
		)
)
		
(check-sat)
(get-model)
(get-value (
	(B 1 1) (B 1 2) (B 1 3) 
	(B 2 1) (B 2 2) (B 2 3)  
	(B 3 1) (B 3 2) (B 3 3)  
	(B 4 1) (B 4 2) (B 4 3) 
	(B 5 1) (B 5 2) (B 5 3)  
	(B 6 1) (B 6 2) (B 6 3)  
	(B 7 1) (B 7 2) (B 7 3)  
	(B 8 1) (B 8 2) (B 8 3)   

))

