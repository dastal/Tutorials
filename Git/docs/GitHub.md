The following part contains all about working with Git and GitHub.

## SSH Keys ##
In order to prove to GitHub we have to prove that we are the owner of the account. Therefore we have to connect our local machine to out GitHub account. This is done by using SSH keys. 
In order to create these SSH keys, open a terminal and enter the command `ssh-keygen -t  rsa -b  4096 -C "email@address.com"`.
- `-t rsa` type of encryption
- `-b 4096` strength of encryption
- `-C "email@address.com"` the e-mail address that the account uses

Entering this command generates the SSH keys inside the user directory in a hidden folder called ".ssh" (you can get this folder by show the hidden folders). The folder where the SSH key is saved in is called "id_rsa".

Inside this folder there are two different files, one called "id_rsa" and the other one called "id_rsa.pub". We upload the key that is located inside the file "id_rsa.pub". The other key is the private key that we have to keep secret. Now everytime when we upload code to our GitHub account we use this private key identify ourselves.

Now we  need to copy the SSH-Key by using the command `pbcopy < <path tho file>`. On GitHub we go to "Settings" >> "SSH and GPG Keys" >>  "Nen SSH Key". There we enter a title of choice, enter the SSH and finally save it. 

## Git Push ##
Now back to the terminal in VS Code. When we want to push something to GitHub, we need to add some more information to the `push` command: `git push origin master`.
- `origin` stands for the location of our Git repository
- `master` branch where we want to push the code

If we want to push a folder we have to navigate to this folder and enter the code `git init`. This command will automatically include the folder.

Then again:
- `git status`
- `git add .`
- `git status`
- `git commmit -m "<description>"`

But then Git gives us the error that it does not know where to push this folder since we did not clone it into GitHub. The solution for this is by creating a new empty repo with the name that we gave this folder before. New we have to copy the SSH-Address in our Git repo and enter the following command to GitHub `git remote add origin <link>` . `remote` means here anywhere else but not on this local machine. To control what we just did we can use the command `git remote -v`, which should list all our remote repositories that we have connected to this repository. Now we can use `git push origin master`.

If we do not want to type out the whole command every time, we can use the command `git push -u origin master` once, and now for every other time when we want to push something to this folder we can just use `git push`.