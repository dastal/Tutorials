# Switch Statements #

A switch statement is basically a special type of if statements, which can be used to comapre one (and only one) value to a bunch of other single values. Its template is as follows:

```
switch($grade){
	case "case1":
		Do case 1;
            break;
      case "case2":
            Do case 2;
            break;
      case "case3":
            Do case 3;
            break;
	default:
          	Do default;
          	break;
}
```

`break`: breaks out of the switch statement, sucht that there does not happen a deadlock.
`default`: if none of the cases happened, do something by default.