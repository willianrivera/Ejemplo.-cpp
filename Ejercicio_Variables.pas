// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

Program ejercicio_variables;

Var
	valor_a: Real;
	valor_b: String;
	valor_c: Boolean;
	valor_d: Boolean;
	valor_e: Boolean;
	valor_w: Array [0..4] Of String;
	valor_x: Integer;
	valor_y: String;
	valor_z: String;
Begin
	valor_x := 75;
	valor_y := '84';
	valor_z := '65';
	valor_a := Sqrt(4);
	valor_b := '2019';
	valor_c := True;
	valor_d := False;
	valor_w[1] := 'H';
	valor_w[2] := 'O';
	valor_w[3] := 'L';
	valor_w[4] := 'A';
	WriteLn(valor_a);
	WriteLn(valor_b);
	WriteLn(valor_c);
	WriteLn(valor_d);
	WriteLn(valor_x);
	WriteLn(valor_y);
	WriteLn(valor_z);
	WriteLn(valor_w[1],valor_w[2],valor_w[3],valor_w[4]);
End.

