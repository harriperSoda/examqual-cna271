# examqual-cna271
The official GitHub repo for the CNA271 Group project 2026
# Code logic and understanding
This application calculates if a student is eligble to take the exam based on 3 marks they inputted. They are
calculated in accordance to pre-defined weightings and averaged to give a final average mark that must meet a requirements
of being greater than 50 to qualify for the exam. 
## Logic 1
 Will require iteration of 4 requesting a mark
    - ERROR HANDLING:
        - Non-numeric
        - Below 0
        - Above 100
        - Null
    - Reloop until connditions met. Will prompt for current mark - will not restart
## Logic 2
Obtain the sum of each inputted mark x weighting --> (test1 * 0.30) + ...

## Logic 3
Validation checks to ensure the above calcualted weighted average is  >= 50
    If it is, you qualify
    If not, you dont qualify
## Purpose
Utilized Docker to build a Docker file containing the application, then pushed that image to Docker Hub so it can be pulled and run on any machine.

