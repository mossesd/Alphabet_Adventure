mbios en el directorio actual de manera recursiva. Si
    se ejecuta desde la raíz del workspace, deshace todos los cambios en el
    workspace completo.)

    $ cm partial co file.txt
    $ cm partial undo file.txt
    (Deshace el checkout en file.txt.)

    $ echo content >> file.txt
    $ cm partial undo file.txt
    (Deshace el cambio local en file.txt.)

    $ cm partial undo src
    (Deshace los cambios en el directorio src y en todos los ficheros
    controlados que contenga)

    $ cm partial undo src/*
    (Deshace los cambios en todos los elementos contenidos en src, sin afectar
    al propio directorio. Por la expansión del wildcard, es equivalente a
    'cm partial undo src/file1.txt src/file2.txt').

    $ cm partial undo *.cs
    (Deshace cambios en cada elemento que encaje con el patrón *.cs en el
    directorio actual.)

    $ cm partial undo *.cs -r
    (Deshace cambios en cada elemento que encaje con el patrón *.cs en el
    directorio actual, y en cada directorio por debajo de una manera recursiva.)

    $ cm partial co file1.txt file2.txt
    $ echo content >> file1.txt
    $ cm partial undo --unchanged
    (Deshace el checkout en file2.txt por no estar modificado, ignorando
    file1.txt ya que tiene cambios locales.)

    $ echo content >> file1.txt
    $ echo content >> file2.txt
    $ cm partial co file1.txt
    $ cm partial undo --checkedout
    (Deshace el cambio en el fichero en checkout file1.txt, ignorando file2.txt
    ya que no está en checkout.)

    $ cm partial add file.txt
    $ cm partial undo file.txt
    (Deshace el añadido de file.txt, dejándolo de nuevo como privado.)

    $ rm file1.txt
    $ echo content >> file2.txt
    $ cm partial add file3.txt
    $ cm partial undo --deleted --added *
    (Deshace el borrado de file1.t