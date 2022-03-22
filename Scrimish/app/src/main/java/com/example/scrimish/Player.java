package com.example.scrimish;

import android.graphics.drawable.Drawable;

import java.io.Serializable;

public class Player implements Serializable {

    // 1 or 2
    private String playerName;
    private int playerNo;
    private int[] pileOne;
    private int[] pileTwo;
    private int[] pileThree;
    private int[] pileFour;
    private int[] pileFive;
    private int[] pileOneDrawableIds;
    private int[] pileTwoDrawableIds;
    private int[] pileThreeDrawableIds;
    private int[] pileFourDrawableIds;
    private int[] pileFiveDrawableIds;
    private boolean isAllPilesAreSelected;
    private boolean defenderOrAttacker; // true for attacker , false for defender
    boolean gender; // true for female, false for male

    public void resetAll() {
        this.pileFiveDrawableIds = new int[5];
        this.pileOneDrawableIds = new int[5];
        this.pileFourDrawableIds = new int[5];
        this.pileTwoDrawableIds = new int[5];
        this.pileThreeDrawableIds = new int[5];
    }

    public void setGender(boolean gender) {
        this.gender = gender;
    }

    public boolean getGender() {
        return this.gender;
    }

    Player() {
        playerName = "";
        isAllPilesAreSelected = false;
        this.pileOne = new int[5];
        this.pileTwo = new int[5];
        this.pileThree = new int[5];
        this.pileFour = new int[5];
        this.pileFive = new int[5];
        this.pileFiveDrawableIds = new int[5];
        this.pileOneDrawableIds = new int[5];
        this.pileFourDrawableIds = new int[5];
        this.pileTwoDrawableIds = new int[5];
        this.pileThreeDrawableIds = new int[5];
        this.defenderOrAttacker = false;
    }


    Player(int playerNo) {
        this.playerNo = playerNo;
    }

    public int getPlayerNo() {
        return playerNo;
    }

    public int[] getPileThree() {
        return pileThree;
    }

    public int[] getPileOne() {
        return pileOne;
    }

    public int[] getPileFour() {
        return pileFour;
    }

    public void setDefenderOrAttacker(boolean defenderOrAttacker) {
        this.defenderOrAttacker = defenderOrAttacker;
    }

    public boolean getDefenderOrAttacker() {
        return this.defenderOrAttacker;
    }

    public int[] getPileFiveDrawableIds() {
        return pileFiveDrawableIds;
    }

    public int[] getPileFourDrawableIds() {
        return pileFourDrawableIds;
    }

    public int[] getPileOneDrawableIds() {
        return pileOneDrawableIds;
    }

    public int[] getPileThreeDrawableIds() {
        return pileThreeDrawableIds;
    }

    public int[] getPileTwoDrawableIds() {
        return pileTwoDrawableIds;
    }

    public void setPileFiveDrawableIds(int[] pileFiveDrawableIds) {
        this.pileFiveDrawableIds = pileFiveDrawableIds;
    }

    public String getPlayerName() {
        return playerName;
    }

    public void setPlayerName(String playerName) {
        this.playerName = playerName;
    }

    public void setPileFourDrawableIds(int[] pileFourDrawableIds) {
        this.pileFourDrawableIds = pileFourDrawableIds;
    }

    public void setPileOneDrawableIds(int[] pileOneDrawableIds) {
        this.pileOneDrawableIds = pileOneDrawableIds;
    }

    public void setPileThreeDrawableIds(int[] pileThreeDrawableIds) {
        this.pileThreeDrawableIds = pileThreeDrawableIds;
    }

    public void setPileTwoDrawableIds(int[] pileTwoDrawableIds) {
        this.pileTwoDrawableIds = pileTwoDrawableIds;
    }

    public int[] getPileTwo() {
        return pileTwo;
    }

    public int[] getPileFive() {
        return pileFive;
    }

    public void setPileTwo(int[] pileTwo) {
        this.pileTwo = pileTwo;
    }

    public void setPileThree(int[] pileThree) {
        this.pileThree = pileThree;
    }

    public void setPileOne(int[] pileOne) {
        this.pileOne = pileOne;
    }

    public void setPileFour(int[] pileFour) {
        this.pileFour = pileFour;
    }

    public void setPileFive(int[] pileFive) {
        this.pileFive = pileFive;
        this.isAllPilesAreSelected = true;
    }

    public boolean getAllPilesAreSelected() {
        return this.isAllPilesAreSelected;
    }

    public void setAllPilesAreSelected(boolean allPilesAreSelected) {
        isAllPilesAreSelected = allPilesAreSelected;
    }

    public void setPlayerNo(int playerNo) {
        this.playerNo = playerNo;
    }
}
